using Person;

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

Child child = new(name, age);
Console.WriteLine(child);

