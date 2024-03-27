using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Factory : Organization
    {
        public int Staff { get; set; }

        public Factory() { }
        public Factory(string name, int staff):base(name)
        {
            this.Staff = staff;
        }
        public override void Print ()
        {
           // base.Print();
            Console.WriteLine($" Количество рабочего персонала: {Staff}");
        }
        static public Factory Show()
        {
            Console.Write("Введите название завода: ");
            string name = Console.ReadLine();
            Console.Write("Введите количество рабочего персонала: ");
            int staff = int.Parse(Console.ReadLine());
            return new Factory(name, staff);
        }
    }
}
