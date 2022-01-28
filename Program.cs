using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    class Program
    {
        static void Main()
        {
            ArithProgression arithprogression = new ArithProgression();
            GeomProgression geomprogression = new GeomProgression();
            ISeries number;
            Console.WriteLine("Ряд четных чисел");
            for (int i = 1; i <= 10; i++)
            {
                number = arithprogression;
                Console.WriteLine("Четное число: " + number.GetNext());                                           
            }
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.WriteLine("***********************");
            
            Console.WriteLine("Ряд простых чисел");
            for (int j = 1; j <= 10; j++)
            {
                number = geomprogression;
                Console.WriteLine("Простое число: " + number.GetNext());
            }
            Console.ReadKey();

        }
        public interface ISeries
        {
            int GetNext();
            void Reset();
            void SetStart(int х);
        }
        class ArithProgression : ISeries
        {
            int start;
            int val;

            public ArithProgression()
            {
                start = 0;
                val = 0;
            }

            public int GetNext()
            {
                val += 2;
                return val;
            }

            public void Reset()
            {
                val = start;
            }

            public void SetStart(int x)
            {
                start = x;
                val = start;
            }
        }

        class GeomProgression : ISeries
        {
            int start;
            int val;
            public GeomProgression()
            {
                start = 2;
                val = 2;
            }

            public int GetNext()
            {
                int i, j;
                bool isprime;
                val++;
                for (i = val; i < 1000000; i++)
                {
                    isprime = true;
                    for (j = 2; j <= i / j; j++)
                    {
                        if ((i % j) == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime)
                    {
                        val = i;
                        break;
                    }
                }
                return val;
            }

            public void Reset()
            {
                val = start;
            }

            public void SetStart(int x)
            {
                start = x;
                val = start;
            }
        }
    }    
   
}
