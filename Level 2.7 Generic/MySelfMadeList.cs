using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._7_Generic
{
    public class MySelfMadeList<T>
    {
        private T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MySelfMadeList()
        {
            MyArray = new T[Size];
        }

        public void AddElement(T elementToAdd)
        {
            if (CheckIfFull())
                MyArray = IncreaseListSize();
            if (elementToAdd != null)
            {
                MyArray[Index] = elementToAdd;
                Index++;
            }
            else
            {
                throw new ArgumentNullException(nameof(elementToAdd));
            }
        }
        public void RemoveElement(T elementToRemove)
        {
            int foundIndex = -1;
            if (elementToRemove != null) // && elementToRemove < MyArray.Count)
            {
                for (int i = 0; i < MyArray.Length; i++)
                {
                    if (MyArray[i].Equals(elementToRemove))
                    {
                        foundIndex = i;
                        break;
                    }
                }

                if (foundIndex != -1)
                {
                    int counter = 0;
                    for (int i = 0; i < MyArray.Length; i++)
                    {
                        if (i != foundIndex)
                        {
                            MyArray[counter] = MyArray[i];
                            counter++;
                        }

                    }
                    Index--;
                }

            }
            else
            {
                throw new ArgumentNullException(nameof(elementToRemove));
            }
        }
        private bool CheckIfFull()
        {
            if (Index == Size)
                return true;
            else
                return false;
        }
        private T[] IncreaseListSize()
        {
            Size += (Size / 2);
            var newArray = new T[Size];
            MyArray.CopyTo(newArray, 0);
            return newArray;
        }
        public void PrintList()
        {
            foreach (T item in MyArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
