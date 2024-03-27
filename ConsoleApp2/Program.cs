using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Organization> organizations = new List<Organization>();
            while (true)
            {
                Console.Write("Введите организацию: ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "цех":
                        Workshop workshop = new Workshop();
                        Workshop.Show();
                        break;
                    case "завод":
                        Factory factory = new Factory();
                        Factory.Show();
                        break;
                    case "0": return;
                    default:
                        Console.WriteLine("Организации не существует");
                        break;
                } 
            }
            Console.ReadKey();
        }
    }
}
