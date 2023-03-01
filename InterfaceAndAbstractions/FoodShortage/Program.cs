using FoodShortage;
using System.Linq;

int lines = int.Parse(Console.ReadLine());
List<IBuyer> buyers = new();

for (int i = 1; i <= lines; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (input.Length == 4)//citizen
    {
        string name = input[0];
        int age = int.Parse(input[1]);
        string id = input[2];
        string birthdate = input[3];
        Citizen citizen = new(name, age, id, birthdate);
        buyers.Add(citizen);
    }
    else if (input.Length == 3)//rebel
    {
        string name = input[0];
        int age = int.Parse(input[1]);
        string group = input[2];
        Rebel rebel = new(name, age, group);
        buyers.Add(rebel);
    }
}
string buyerName = Console.ReadLine();
while (buyerName != "End")
{
    if (buyers.Any(b => b.Name == buyerName))
    {
        IBuyer buyer = buyers.Find(b => b.Name == buyerName);
        buyer.BuyFood();
    }
    buyerName = Console.ReadLine();
}
Console.WriteLine(buyers.Select(b => b.Food).Sum());
