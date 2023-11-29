using System;
using System.Collections.Generic;

namespace USR1
{
    public class UsingListCase
    {
        private List<int> _randomNums = new List<int>();

        public UsingListCase()
        {
            GenerateList();
            RemoveNumsThatSplitFirstElement();
            Console.WriteLine(_randomNums.Count);
            AddZeros();
            Console.WriteLine(_randomNums.Count);
        }

        private void GenerateList()
        {
            Random random = new Random();
            for (int i = 0; i < 100000; i++)
            {
                _randomNums.Add(random.Next(1, 10));
            }
        }

        private void RemoveNumsThatSplitFirstElement()
        {
            int firstElement = _randomNums[0];
            _randomNums.RemoveAll(element => element % firstElement == 0);
        }

        private void AddZeros()
        {
            for (int i = 0; i < 99999; i++)
            {
                if (_randomNums[i] % 2 == _randomNums[i + 1])
                {
                    _randomNums.Insert(i, 0);
                }
            }
        }
    }
}