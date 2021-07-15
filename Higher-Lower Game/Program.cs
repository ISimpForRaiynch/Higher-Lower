using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ISFR (I Simp For Rainych) Higher-Lower game:");
            Console.WriteLine("Ok Set A Minimum For Your Game!");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Write a Maximum: ");
            int max = int.Parse(Console.ReadLine());
            Random r = new Random();
            int num = r.Next(min, max);
            bool x = false;
            do
            {
                Console.Write("Guess A number:");
                int myNum = int.Parse(Console.ReadLine());
                if (myNum > num)
                {
                    Console.WriteLine("Too High Guess Lower");
                }
                else if (num > myNum)
                {
                    Console.WriteLine("Too Low!! Guess Higher!");
                }
                else
                {
                    Console.WriteLine("Good Job you guessed the number! Have a cookie ");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            } while (x == false);
        }
    }
}