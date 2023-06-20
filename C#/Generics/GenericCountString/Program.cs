using GenericCountString;

int n = int.Parse(Console.ReadLine());
var box = new Box<string>();

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    box.Add(input);
}
string compare = Console.ReadLine();
Console.WriteLine(box.Compare(compare));
