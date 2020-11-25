using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Employees : Person 
    {
        private int expirience;
        public string Post;
        public int Expirience
        {
            set
            {
                if (value > 0)
                {
                    expirience = value;
                }
                else
                {
                    Console.WriteLine("Стаж должен быть больше 0");
                }
            }
            get
            {
                return expirience;
            }
        }

        public Employees(string FirstName, string LastName, string Patronymic, int Expirience, string Post)
            : base(FirstName, LastName, Patronymic)
        {
            this.Expirience = Expirience;
            this.Post = Post;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {FirstName}, Фамилия: {LastName}, Отчество: {Patronymic}, \n Стаж: {Expirience}, Должность: {Post}");
        }
    }
}
