using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Workshop : Organization
    {
        public int WorkingDays { get; set; }

        public Workshop() { }
        public Workshop(string name, int workingDays):base(name)
        {
            this.WorkingDays = workingDays;
        }

        public override void Print()
        {
           // base.Print();
            Console.WriteLine($"Количество рабочих дней: {WorkingDays}");
        }
        static public Workshop Show()
        {
            Console.Write("Введите название цеха: ");
            string name = Console.ReadLine();
            Console.Write("Введите количество рабочих дней: ");
            int workingDays = int.Parse(Console.ReadLine());
            return new Workshop(name, workingDays);
        }
    }
}
