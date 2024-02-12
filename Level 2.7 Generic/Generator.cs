using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._7_Generic
{
    internal class Generator<T>
    {
        public void Show(T obj)
        {
            if (obj != null && obj.GetType().GetMethod("ToString") != null)
            {
                string stringValue = obj.ToString();
                Console.WriteLine(stringValue);
            }
            else
            {
                Console.WriteLine("Object doesn't have a ToString method or is null.");
            }
        }
    }
}
