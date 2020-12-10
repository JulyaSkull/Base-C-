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
            Employees<string> emp1 = new Employees<string>("4", "Александра", "Волкова", "Анатольевна", 14, "Главный менеджер");
            Console.WriteLine(emp1.ToString());
            Console.WriteLine("\n****************************************************************");
            Employees<int> emp2 = new Employees<int>(1, "Максим", "Иванов", "Евгеньевич", 11, "Бухгалтер");
            Console.WriteLine(emp2.ToString()); 
            Console.WriteLine("\n****************************************************************");
            Employees<int> emp3 = new Employees<int>(3, "Крупина", "Любовь", "Сергеевна", 11, "Бухгалтер");
            Console.WriteLine(emp3.ToString());
            Console.WriteLine("\n****************************************************************");
            Employees<int> emp4 = new Employees<int>(2, "Ильин", "Тимофей", "Александрович", 13, "Старший программист");
            Console.WriteLine(emp4.ToString());

            Console.WriteLine(emp2.Equals(emp3));
            Console.ReadKey();
        }
    }
}
