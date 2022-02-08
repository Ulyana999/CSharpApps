using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2
{
    internal class Person
    {
        string name;
        int age;
        string profession;
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name, string profession)
        {
            this.name = name;
            this.profession = profession;
        }
        public Person(string name, int age, string profession)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
        }

        public string GetInformation()
        {
            string information;
            information = "Имя: " + this.name + "; Возраст: " + this.age.ToString() + "; Профессия: " + this.profession;
            return information; 

        }
        
    }

}
