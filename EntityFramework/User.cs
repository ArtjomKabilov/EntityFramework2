using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class User
    {
        int id;
        string name;
        int age;
        public int Id => id;
        public int Age => age;
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Print() => Console.WriteLine($"{id}. {name} - {age}");
    }

}
