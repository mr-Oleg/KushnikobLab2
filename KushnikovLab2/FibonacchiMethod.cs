
using System;
using System.Collections.Generic;

namespace KushnikovLab2
{
    class FibonacchiMethod : CalculationBehavior
    {

        private const int A = 4;
        private const int B = 1;
        private int currentIteration = 4;
        private Random random = new Random();
        private bool isFirstCalculation = true;

        private List<double> startedValues;

        public double calculate()
        {
            double val;
            init();
            if(startedValues[currentIteration - A - 1] >= startedValues[currentIteration - B - 1])
            {
                val = startedValues[currentIteration - A - 1] - startedValues[currentIteration - B - 1];
            }
            else
            {
                val = startedValues[currentIteration - A - 1] - startedValues[currentIteration - B - 1] + 1;
            }
            startedValues.Add(val);
            currentIteration++;
            return val;
        }

        private void init()
        {
            if (isFirstCalculation) {
                startedValues = new List<double>();
                for (int iteration = 0; iteration < currentIteration; iteration++)
                {
                    startedValues.Add(random.NextDouble());
                }
                currentIteration++;
                isFirstCalculation = false;
            }
        }
    }
}
