using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class AtomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Func<int> GetNumberfromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoice { get; set; }
        public Func<int, int, int, double> Calculate { get; set; }
        public Action<double> ResultPrinter { get; set; }

        public void Run()
        {
            X = GetNumberfromUser.Invoke();
            Y = GetNumberfromUser.Invoke();
            MenuPrinter.Invoke();
            int UserChoice = GetUserChoice.Invoke();
            double Result = Calculate.Invoke(X, Y, UserChoice);
            ResultPrinter.Invoke(Result);
        }

    }
}
