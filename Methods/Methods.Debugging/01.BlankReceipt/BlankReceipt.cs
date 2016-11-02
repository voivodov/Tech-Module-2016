using System; 

namespace _01.BlankReceipt
{
    class BlankReceipt
    {
        
        static void Main( )
        {
            PrintReceipt();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
            Console.WriteLine("------------------------------");
        }
        static void PrintFooter()
        {
              Console.WriteLine("© SoftUni");
        }
        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

    }
}
