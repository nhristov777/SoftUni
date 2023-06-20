using Tuple;

string[] personInfo = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] beerInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] numbersInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

CustomTuple<string, string> person = new($"{personInfo[0]} {personInfo[1]}", personInfo[2]);
CustomTuple<string, int> beer = new(beerInfo[0], int.Parse(beerInfo[1]));
CustomTuple<int, double> numbers = new(int.Parse(numbersInfo[0]), double.Parse(numbersInfo[1]));

Console.WriteLine(person);
Console.WriteLine(beer);
Console.WriteLine(numbers);
