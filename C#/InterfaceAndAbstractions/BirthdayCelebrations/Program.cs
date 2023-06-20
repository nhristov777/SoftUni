using BorderControl;
using BirthdayCelebrations;
string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
List<IBirthable> entities = new();

while (input[0] != "End")
{
    if (input[0] == "Citizen")//robot
    {
        string name = input[1];
        int age = int.Parse(input[2]);
        string id = input[3];
        string birthdate = input[4];
        Citizen citizen = new(name, age, id, birthdate);
        entities.Add(citizen);
    }
    else if (input[0] == "Pet")
    {
        string name = input[1];
        string birthdate = input[2];
        Pet pet = new(name, birthdate);
        entities.Add(pet);
    }
    input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}
string year = Console.ReadLine();
foreach (var entity in entities)
{
    if(ValidYear(entity.Birthdate, year))
        Console.WriteLine(entity.Birthdate);
}

static bool ValidYear(string birthdate, string year)
{
    if (birthdate.EndsWith(year)) return true;
    return false;
}