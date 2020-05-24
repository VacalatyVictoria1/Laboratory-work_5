using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_4
{
    public class Engineer : Employee
    {
        private int work_experiance;
        public int Work_experiance { get => work_experiance; set => work_experiance = value; }

        public Engineer(string name, string country, string city, string sex, int age, int work_experiance)
            : base(name, country, city, sex, age)
        {
            Work_experiance = work_experiance;
        }
        public Engineer()
        {
        }
        public void Print_Engineer()
        {
            Console.WriteLine("\nWork Experiance: " + Work_experiance);
        }
        public void Edit_Engineer()
        {
            Console.Clear();
            Console.WriteLine("Change field of work experiance:\n");
            Work_experiance = Convert.ToInt32(Console.ReadLine());
        }
    }
}
