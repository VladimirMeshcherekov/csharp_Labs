using System;
using System.Collections.Generic;

namespace USR1
{
    public class UsingLinkedListCase
    {
        private LinkedList<int> _randomNums = new LinkedList<int>(new[] { 2 });

        public UsingLinkedListCase()
        {
            GenerateList();
            Console.WriteLine(_randomNums.Count);
            RemoveNumsThatSplitFirstElement();
            Console.WriteLine(_randomNums.Count);
            AddZeros();
            Console.WriteLine(_randomNums.Count);
        }

        private void GenerateList()
        {
            Random random = new Random();
            var currentNode = _randomNums.First;

            for (int i = 1; i < 100000; i++)
            {
                _randomNums.AddAfter(currentNode, random.Next(1, 10));
                currentNode = currentNode.Next;
            }
        }

        private void RemoveNumsThatSplitFirstElement()
        {
            var currentNode = _randomNums.First;
            while (currentNode != null)
            {
                if (currentNode.Next?.Value % _randomNums.First?.Value == 0)
                {
                    _randomNums.Remove(currentNode.Next);
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }

        private void AddZeros()
        {
            var currentNode = _randomNums.First;
            while (currentNode != null)
            {
                if (currentNode.Value % 2 == currentNode.Next?.Value % 2)
                {
                    _randomNums.AddAfter(currentNode, 0);
                    currentNode = currentNode.Next?.Next;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }
    }
}