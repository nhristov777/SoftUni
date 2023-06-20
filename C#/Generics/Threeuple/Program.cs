using Threeuple;

string[] personInfo = Console.ReadLine()
.Split(" ", StringSplitOptions.RemoveEmptyEntries)
.ToArray();

string[] beerInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] bankInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

CustomTuple<string, string, string> person = 
    new($"{personInfo[0]} {personInfo[1]}", personInfo[2], personInfo[3]);

CustomTuple<string, int, bool> beer = 
    new(beerInfo[0], int.Parse(beerInfo[1]), beerInfo[2]== "drunk");

Console.WriteLine(person);
Console.WriteLine(beer);

Console.WriteLine(new CustomTuple<string, double, string>(bankInfo[0], double.Parse(bankInfo[1]), bankInfo[2]));
