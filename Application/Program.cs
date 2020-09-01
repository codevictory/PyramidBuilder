using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pharaoh demands a new pyramid!");

            System.Console.WriteLine("What should be the height of the pyramid be?");

            var height = Convert.ToInt32(System.Console.ReadLine());

            var nextLevel = 1;
            var air = height - 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < air; j++)
                {
                    System.Console.Write(' ');
                }
                for (int j = 0; j < nextLevel; j++)
                    System.Console.Write('#');
                System.Console.Write('\n');
                nextLevel += 2;
                air--;
            }

            System.Console.WriteLine("\nPyramid is ready! Press enter to exit.");

            var end = System.Console.ReadLine();
        }
    }
}
