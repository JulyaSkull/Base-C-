using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person emp1 = new Employees("Александра", "Волкова", "Анатольевна", 14, "Главный менеджер");
            emp1.GetInfo();
            Console.WriteLine("\n****************************************************************");
            Employees emp2 = new Employees("Максим", "Иванов", "Евгеньевич", 5, "Бухгалтер");
            emp2.GetInfo();
            Console.WriteLine("\n****************************************************************");
            Employees emp3 = new Employees("Крупина", "Любовь", "Сергеевна", 11, "Секретарь");
            emp3.GetInfo();
            Console.WriteLine("\n****************************************************************");
            Employees emp4 = new Employees("Ильин", "Тимофей", "Александрович", 13, "Старший программист");
            emp4.GetInfo();
            Console.ReadKey();
        }
    }
}
