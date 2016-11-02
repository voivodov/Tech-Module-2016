using System; 

namespace _08.RefactorVolumeOfPyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            double length, width, heigth, volume = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());
            volume = (double)(length * width * heigth) / 3.0;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
