using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("請輸入身高");
            string heigh = Console.ReadLine();
            double Heigh = double.Parse(heigh);

            Console.WriteLine("請輸入體重");
            string weight = Console.ReadLine();
            double Weight = double.Parse(weight);

            double bmi = (Weight / ((Heigh / 100) * (Heigh / 100)));


            Console.WriteLine("你的BMI為" + bmi.ToString());


            if (bmi < 18.5)
            {
                Console.WriteLine("你過輕了");
            }
            if (bmi > 24)
            {
                Console.WriteLine("你過重了");
            }
            if (bmi > 18.5 && bmi < 24)
            {
                Console.WriteLine("太棒了!你很正常");
            }

            {
                if (bmi < 16.5 || bmi > 31.5)
                {
                    Console.WriteLine("免役囉");

                }
                else
                {
                    Console.WriteLine("要服役喔");

                }
                Console.ReadLine();
            }
        }
    }
}
