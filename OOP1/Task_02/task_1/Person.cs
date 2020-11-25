using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }

        public Person(string FirstName, string LastName, string Patronymic)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Patronymic = Patronymic;
        }

        abstract public void GetInfo();
    }
}
