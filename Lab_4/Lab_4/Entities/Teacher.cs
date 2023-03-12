using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Entities
{
    public class Teacher
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public List<Discipline> Disciplines { get; set; }

        public Teacher() 
        {
            Name = string.Empty;
            Salary = 0;
            Disciplines = new List<Discipline>();
        }

        public Teacher(string name, double salary)
        {
            Name = name;
            Salary = salary;
            Disciplines = new List<Discipline>();
        }

        public IEnumerable<Discipline> GetDisciplines()
        {
            foreach (var item in Disciplines)
            {
                yield return item;
            }
        }

        public void Add_Discipline(Discipline new_discipline)
        {
            Disciplines.Add(new_discipline);
        }

    }
}
