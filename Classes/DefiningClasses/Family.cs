using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;
        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }
        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            return People.OrderByDescending(p => p.Age).First();
        }
        public List<Person> GetOverThirty()
        {
            return People.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
        }
    }
}
