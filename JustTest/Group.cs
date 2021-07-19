using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTest
{
    class Group : IEnumerable
    {
        List<Person> groupOfPersons = new List<Person>();

        public string GroupName { get; set; }

        public int GroupNumber { get; set; }

        public void Add(Person person)
        {
            groupOfPersons.Add(person);
        }

        public IEnumerator GetEnumerator()
        {
            return groupOfPersons.GetEnumerator();
        }
    }
}
