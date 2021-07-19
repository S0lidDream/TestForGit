using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { FirstName = "Иван", LastName = "Иванов", Age = 25 };
            Person person2 = new Person() { FirstName = "Петр", LastName = "Петров", Age = 26 };
            Group group = new Group() { GroupName = "Группа 1", GroupNumber = 1 };

            group.Add(person1);
            group.Add(person2);

            foreach(var pers in group)
            {
                Console.WriteLine(pers);
            }
            Console.WriteLine();
            Console.WriteLine(group[1]);
            Console.ReadKey();
        }
    }
}
