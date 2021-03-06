﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.СръбскоUnleashed
{
    class СръбскоUnleashed
    {
        static void Main(string[] args)
        {
            var VenuesIncome = new Dictionary<string, Dictionary<string, long>>();

            string pattern = @"(\w+(?: \w+)*) @(\w+(?: \w+)*) (\d+) (\d+)";
            Regex regex = new Regex(pattern);

            while (true)
            {
                var inputedInfo = Console.ReadLine();
                if (inputedInfo == "End")
                {
                    break;
                }
                if (!regex.IsMatch(inputedInfo))
                {
                    continue;
                }


                var WholeInfoParts = inputedInfo.Split(new char[] { '@' }).ToArray();

                //proverka dali sa tochno dumite
                if ((WholeInfoParts[0].Count(Char.IsWhiteSpace) == 0 ||
                    WholeInfoParts[0].Count(Char.IsWhiteSpace) > 3) ||
                    (WholeInfoParts[1].Count(Char.IsWhiteSpace) < 2 ||
                    WholeInfoParts[1].Count(Char.IsWhiteSpace) > 4))
                {
                    continue;
                }

                string[] secondPartInfo = WholeInfoParts[1].Split().ToArray();

                string venue = "";
                int ticketPrice = 0;
                int ticketsCount = 0;
                string singer = WholeInfoParts[0].Trim();

                if (secondPartInfo.Length == 3)
                {
                    venue = secondPartInfo[0];
                    ticketPrice = int.Parse(secondPartInfo[1]);
                    ticketsCount = int.Parse(secondPartInfo[2]);
                }
                else if (secondPartInfo.Length == 4)
                {
                    venue = secondPartInfo[0] + " " + secondPartInfo[1];
                    ticketPrice = int.Parse(secondPartInfo[2]);
                    ticketsCount = int.Parse(secondPartInfo[3]);
                }
                else if (secondPartInfo.Length == 5)
                {
                    venue = secondPartInfo[0] + " " + secondPartInfo[1] + " " + secondPartInfo[2];
                    ticketPrice = int.Parse(secondPartInfo[3]);
                    ticketsCount = int.Parse(secondPartInfo[4]);
                }


                if (!VenuesIncome.ContainsKey(venue))
                {
                    VenuesIncome.Add(venue, new Dictionary<string, long>());
                }

                if (!VenuesIncome[venue].ContainsKey(singer))
                {
                    VenuesIncome[venue].Add(singer, 0);
                }

                VenuesIncome[venue][singer] += ticketPrice * ticketsCount;

            }

            //print the venues

            foreach (var VenueData in VenuesIncome)
            {
                Console.WriteLine(VenueData.Key);
                var orderedSingersList = VenueData.Value.OrderByDescending(x => x.Value).ToList();

                foreach (var singerData in orderedSingersList)
                {
                    Console.WriteLine($"#  {singerData.Key} -> {singerData.Value}");
                }
            }
         }
    }
}
