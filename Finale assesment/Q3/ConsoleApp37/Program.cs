using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//jacques rockell
namespace ConsoleApp37
{
    class Program
    {
        static void Main()
        {
            //new random
            Random rand = new Random();
            //declearing array1 and 2 
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];

            Console.WriteLine("Matrix A");

            //nested for loop to iterate through the 2d array
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    array1[i, j] = rand.Next(-10, 10);
                    Console.Write(array1[i, j]+"\t");
                }
                Console.WriteLine();   
            }

            Console.WriteLine("\n     +");
            Console.WriteLine("Matrix B");

            //another nested loop 
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    array2[i, j] = rand.Next(-10, 10);
                    Console.Write(array2[i, j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n     =");
            Console.ReadLine();
            Console.WriteLine("Matrix C");
            
            //adds array1 and array 2 and writes it to console
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(array1[i, j] + array2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //give option to reset it
            Console.WriteLine("\n\nPress (1) to reset\nPress Enter To exit");
            string input = Console.ReadLine();
            if(input == "1")
            {
                Console.Clear();
                Main();
            }
            else if(input != "1")
            {
                System.Environment.Exit(1);
            }
        }
    }
}
