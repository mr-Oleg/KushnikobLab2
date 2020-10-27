using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KushnikovLab2
{
    class AlgoFactory
    {
        public static CalculationBehavior getImplementation(string value)
        {
            switch (value)
            {
                case "Random": return new RandomMethod();
                case "Fon-Neyman": return new FonNeymanMethod();
                case "Fibonachi": return new FibonacchiMethod();
                default: return new RandomMethod();
            }
        }
    }
}
