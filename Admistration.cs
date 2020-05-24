using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_4
{
    public class Admistration : Staff
    {
        private string position;
        public string Position { get => position; set => position = value; }
        public Admistration(string name, string country, string city, string sex, int age, int work_experiance, int amount_employe, string position)
            : base(name, country, city, sex, age, work_experiance, amount_employe)
        {
            Position = position;
        }
        public Admistration()
        {
        }
        public void Print_Admistration()
        {
            Console.WriteLine("\nPosition: " + Position);
        }
        public void Edit_Admistration()
        {
            Console.Clear();
            Console.WriteLine("Change the field about the position:\n");
            Position = Console.ReadLine();
        }

    }
}
