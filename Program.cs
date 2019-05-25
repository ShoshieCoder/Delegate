using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            AtomicCalculator atomic = new AtomicCalculator();
            SimpleCalculator simple = new SimpleCalculator();

            atomic.GetNumberfromUser = simple.NumberGetter;
            atomic.MenuPrinter = simple.PrintMenu;
            atomic.GetUserChoice = simple.GetUserChoice;
            atomic.Calculate = simple.Calculate;
            atomic.ResultPrinter = simple.PrintResultNicely;
            atomic.ResultPrinter += (result) => Console.WriteLine($"Your result: {result}");
            atomic.Run();
        }
    }
}
