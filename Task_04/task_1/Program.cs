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
         
                Animal animal_1 = new Animal(1, "Бурый медведь", "Млекопитающие");
                Animal animal_2 = new Animal(2, "Лисица", "Млекопитающие");
                Animal animal_3 = new Animal(3, "Комар", "Насекомые");
                Animal animal_4 = new Animal(4, "Форель", "Рыбы");
                Animal animal_5 = new Animal(5, "Синица", "Птицы");
                Animal animal_6 = new Animal(6, "Заяц", "Млекопитающие");

                List<Animal> list_of_animals = new List<Animal>() { animal_1, animal_2, animal_3, animal_4, animal_5,  animal_6};

                List<Animal> temp1 = list_of_animals.OrderBy(x1 => x1.animal_class).ToList();

                Console.WriteLine("Enter number:");
                try
                {
                    int enter = int.Parse(Console.ReadLine());
                    Console.WriteLine("All right");
                }
                catch (FormatException)
                {
                Console.WriteLine("Error!");
                }
                Console.ReadKey();
        }
    }
}
