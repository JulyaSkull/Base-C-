using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Employees<T> : Person 
    {
        private int expirience;
        public string Post;
        public T ID { get; set; }
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

        public Employees(T ID, string FirstName, string LastName, string Patronymic, int Expirience, string Post)
            : base(FirstName, LastName, Patronymic)
        {
            this.ID = ID;
            this.Expirience = Expirience;
            this.Post = Post;
        }

        public override string ToString()
        {
            return String.Format($" ID работника:{ID} Имя: {FirstName}, Фамилия: {LastName}, Отчество: {Patronymic}, \n Стаж: {Expirience}, Должность: {Post}");
        }

        public override bool Equals(object obj)
        {
            return obj is Employees<T> employees &&
                   expirience == employees.expirience &&
                   Post == employees.Post;
        }
    }
}
