using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17_Class
{
    internal class Store
    {
        public Store(string name, int openYear, List<string> products)
        {
            OpenYear = openYear;
            Name = name;
            Products = products;
        }

        public int OpenYear { get; set; }
        public string Name { get; set; }

        public List<string> Products { get; set; }
    }

}
