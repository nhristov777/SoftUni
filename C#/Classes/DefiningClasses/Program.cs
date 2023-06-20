namespace DefiningClasses
{
    public class StartUp
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new();
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = array[0];
                int age = int.Parse(array[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }
            List<Person> overage = family.GetOverThirty();
            overage.ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}
