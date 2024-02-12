using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Exam.Models
{
    public class FoodItems
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id};{Name};{Price};{Type}";
        }

    }
}
