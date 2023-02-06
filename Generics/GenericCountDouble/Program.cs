using GenericCountDouble;

int n = int.Parse(Console.ReadLine());
var box = new Box<double>();

for (int i = 0; i < n; i++)
{
    double input = double.Parse(Console.ReadLine());
    box.Add(input);
}
double compare = double.Parse(Console.ReadLine());
Console.WriteLine(box.Compare(compare));
