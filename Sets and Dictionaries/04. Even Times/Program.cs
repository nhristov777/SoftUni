int n = int.Parse(Console.ReadLine());
var numbers = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (!numbers.ContainsKey(number))
    { numbers.Add(number, 1); }
    else numbers[number]++;
}

foreach (var (number, count) in numbers)
{
    if (count % 2 == 0) { Console.WriteLine(number); break; }
}
