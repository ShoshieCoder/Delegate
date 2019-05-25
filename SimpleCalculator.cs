using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class SimpleCalculator
    {
        public int NumberGetter()
        {
            int num = -1;
            while (num < 0)
            {
                Console.WriteLine("Please enter a positive number...");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Operation menu:\n"+
                "1) '+' \n"+
                "2) '-' \n"+
                "3) '*' \n"+
                "4) '/' \n");
        }

        public int GetUserChoice()
        {
            int num = 0;
            while (num > 4 || num < 1)
            {
                Console.WriteLine("Please enter a number between 1 and 4...");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }

        public double Calculate(int n1, int n2, int oper)
        {
            switch (oper)
            {
                case 1 : return n1 + n2;
                case 2 : return n1 - n2;
                case 3 : return n1 * n2;
                case 4 : return n1 / n2;
                default: return -1;    
            }
        }

        public void PrintResultNicely(double result)
        {
            Console.WriteLine("Your result:");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.WriteLine($"***************{result}***************");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
        }
    }
}
