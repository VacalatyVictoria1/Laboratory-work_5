using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_4
{
    class Program
    {
        delegate void Method();

        static void Edit(Admistration admistration)
        {
            int selection = 0;
            Console.WriteLine("Choose menu: (1 - Name | 2 - Work experience | 3 - Amount employees | 4 - Position)\n");
            selection = Convert.ToInt32(Console.ReadLine());
            Method edit;
            switch (selection)
            {
                case 1:
                    edit = admistration.Edit_Employee;
                    edit();
                    break;
                case 2:
                    edit = admistration.Edit_Engineer;
                    edit();
                    break;
                case 3:
                    edit = admistration.Edit_Staff;
                    edit();
                    break;
                case 4:
                    edit = admistration.Edit_Admistration;
                    edit();
                    break;
                default:
                    Console.WriteLine("Error input");
                    break;
            }
        }
        static void Print(Admistration admistration)
        {
            Console.Clear();
            Method pointer;
            pointer = admistration.Print_Employee;
            pointer += admistration.Print_Engineer;
            pointer += admistration.Print_Staff;
            pointer += admistration.Print_Admistration;
            pointer();
        }
        static void Main(string[] args)
        {
            int selection = 0;
            Admistration admistration = new Admistration("Ann", "Ukraine", "Odessa", "Woman", 25, 7, 5, "Manager");

            Print(admistration);

        Link:
            Console.WriteLine("\nDo you want to edit infornation? (Yes - 1 | Exit - 2)");
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Edit(admistration);
                    Print(admistration);
                    goto Link;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nError input!");
                    goto Link;
            }
            Console.ReadKey();
        }



    }
}
