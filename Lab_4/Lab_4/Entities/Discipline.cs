using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Entities
{
    public class Discipline
    {
        public string Title { get; set; }
        public int Hours { get; set; }

        public Discipline()
        {
            Title = string.Empty;
            Hours = 0;
        }

        public Discipline(string title, int hours)
        {
            Title = title; 
            Hours = hours;
        }
    }
}
