using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_4
{
    public class Employee : IData, ILocation
    {
        private string name;
        private string country;
        private string city;
        private string sex;
        private int age;
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value >= 18 && value <= 75 ? value : 18; }

        public Employee(string name, string country, string city, string sex, int age)
        {
            Name = name;
            Country = country;
            City = city;
            Sex = sex;
            Age = age;
        }

        public Employee()
        {
        }
        public void Print_Employee()
        {
            Console.WriteLine("\nName: " + Name + "\nGender: " + Sex + "\nAge: " + Age + "\nCountry: " + Country + "\nCity: " + City);
        }

        public void Edit_Employee()
        {
            Console.Clear();
            Console.WriteLine("Change the name field:\n");
            Name = Console.ReadLine();
        }
        
    }
}
