using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("輸入體重:");
            double kg = double.Parse(Console.ReadLine());
            Console.Write("輸入身高:");
            double cm = double.Parse(Console.ReadLine());
            double BMI = kg/((cm*0.01)*(cm * 0.01));
            Console.WriteLine("BMI值為:"+ BMI);
           
            if (BMI < 18.5)
            {
                Console.WriteLine("體重過輕，還是去當兵");
            }

            if (BMI >= 18.5 && BMI < 24)
            {
                Console.WriteLine("正常範圍，當兵定辣");
            }

            if (BMI >= 24 && BMI < 31)
            {
                Console.WriteLine("過重，可是還是要當兵喔");
            }


            if (BMI > 31)
            {
                Console.WriteLine("過重，肥到不用當兵");
                Console.Beep(100, 100);
            }

            Console.ReadLine();
        }
    }
}
