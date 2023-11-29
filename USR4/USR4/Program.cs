using System;
using System.Collections.Generic;
using System.Linq;

namespace USR4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            USR4 usr4 = new USR4();
        }

        class USR4
        {
            private List<int> _numbers = new List<int>();

            public USR4()
            {
                Init();
                UsingFor();
                UsingForeach();
                UsingLinqRequest();
                UsingLinqAddition();
            }

            void Init()
            {
                for (int i = 1; i < 11; i++)
                {
                    _numbers.Add(i);
                }
            }

            private void UsingFor()
            {
                int result = 0;
                for (int i = 0; i < _numbers.Count; i++)
                {
                    if (_numbers[i] % 2 == 0)
                    {
                        result += _numbers[i] * _numbers[i];
                    }
                }

                Console.WriteLine(result);
            }


            private void UsingForeach()
            {
                int result = 0;
                foreach (var num in _numbers)
                {
                    if (num % 2 == 0)
                    {
                        result += num * num;
                    }
                }

                Console.WriteLine(result);
            }


            private void UsingLinqRequest()
            {
                int result = (from i in _numbers
                    where i % 2 == 0
                    select i * i).Sum();
                Console.WriteLine(result);
            }

            private void UsingLinqAddition()
            {
                int result = (from i in
                        _numbers.Where(i => i % 2 == 0)
                        select i * i).Sum();
                Console.WriteLine(result);
            }
        }
    }
}