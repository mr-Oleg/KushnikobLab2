using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KushnikovLab2
{
    class RandomMethod : CalculationBehavior
    {
        private Random random = new Random();

        public double calculate()
        {
            return random.NextDouble();
        }
    }
}
