using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        private string name;
        private int capacity;
        private List<Child> registry;
        public string Name { get { return name; } set { name = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int ChildrenCount { get { return Registry.Count; } }
        public List<Child> Registry { get { return registry; } set { registry = value; } }
        public Kindergarten(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            this.registry = new List<Child>();
        }

        public bool AddChild(Child child)
        {
            if (registry.Count < capacity)
            { registry.Add(child); return true; }
            return false;
        }
        public bool RemoveChild(string fullName)
        {
            foreach (var child in registry)
            {
                string childName = $"{child.FirstName} {child.LastName}";
                if(childName == fullName) 
                { registry.Remove(child);
                   return true; }
            }
            return false;
        }
        public Child GetChild(string fullName)
        {
            foreach (var child in registry)
            {
                string childName = $"{child.FirstName} {child.LastName}";
                if (childName == fullName) { return child; }
            }
            return null;
        }
        public string RegistryReport()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Registered children in {name}:");
            foreach (var child in registry.OrderByDescending(c => c.Age).ThenBy(c => c.LastName)
                .ThenBy(c => c.FirstName).ToList())
            {
                sb.AppendLine($"{child}");
            }
            return sb.ToString().Trim();
        }
    }
}
