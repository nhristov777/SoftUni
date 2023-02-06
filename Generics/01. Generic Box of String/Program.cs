using BoxOfT;

int n = int.Parse(Console.ReadLine());
var box = new Box<string>();

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    box.Add(input);
}

Console.WriteLine(box.ToString());
