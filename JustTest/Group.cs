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

        public Person this[int position]
        {
            get
            {
                if(position >=0 && position < groupOfPersons.Count)
                {
                    return groupOfPersons[position];
                }
                return null;
            }
            set
            {
                if(position >= 0 && position < groupOfPersons.Count)
                {
                    groupOfPersons[position] = value;
                }
            }
        }




        public IEnumerator GetEnumerator()
        {
            return groupOfPersons.GetEnumerator();
        }
    }
}
