using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KushnikovLab2
{
    /*
     * Основной функционал класса:
     * Представляет собой обертку для
     * массива. Если посмотреть в методичку,
     * то можно обнаружить, что количество 
     * столбиков равно 20 всегда на демо-диаграммах.
     * Таким образом, здесь будет массив размера 20 по умолчанию.
     * Пример: arr[i] будет представлять собой диапазон,
     * а значение ячейки массива будет количеством
     * попаданий в этот дипазон. 
     * Пример конкретный: Сгенерилось число 0,01.
     * Ячейка arr[0] являет собой диапазон [0-0,05)
     * Ячейка arr[1] являет собой диапазон [0,05-0,1) и тд.
     * Значение на вход (0,01 в нашем случае) 
     * увеличит текущее значение ячейки arr[0] на 1.
     */
    class DataWrapperForDistibution
    {
        private int arraySize = 20;
        private int[] arr = new int[20];
        private double step = 0.05;

        private static DataWrapperForDistibution instance = new DataWrapperForDistibution();

        private DataWrapperForDistibution() { }

        public static DataWrapperForDistibution getInstance()
        {
            return instance;
        }

        public void setArraySize(int value)
        {
            if(value > 0)
            {
                arraySize = value;
                step = 1 / arraySize;
                reset();
            }
        }

        public void reset()
        {
            arr = new int[arraySize];
        }

        public int[] getArray()
        {
            int[] copy = new int[arraySize];
            Array.Copy(arr, copy, arraySize);
            return copy;
        }

        private int calculateColumn(double value)
        {
            double localStep = step - 0.0000001;
            int column = 0;
            while (value > localStep)
            {
                localStep += step;
                column++;
            }
            return column;
        }

        public void addValue(double value)
        {
            Console.WriteLine("Column is " + calculateColumn(value) + " for value = " + value);
            arr[calculateColumn(value)] = arr[calculateColumn(value)] + 1;
        }
    }
}
