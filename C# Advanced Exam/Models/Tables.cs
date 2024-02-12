using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Advanced_Exam.Models
{
    public class Tables
    {
        public string TableNumber { get; set; }
        public int Seats { get; set; }
        public string TableOccupation { get; set; }
        public override string ToString()
        {
            return $"{TableNumber};{Seats};{TableOccupation}";
        }

    }


}
