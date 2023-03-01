using BorderControl;

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
List<IIdentifiable> entities = new();
while(input[0] != "End")
{
    if(input.Length == 3)//human
    {
        string name = input[0];
        int age = int.Parse(input[1]);
        string id = input[2];

        Citizen citizen = new(name, age, id);
        entities.Add(citizen);
    }
    else if(input.Length == 2)//robot
    {
        string model = input[0];
        string id = input[1];

        Robot robot = new(model, id);
        entities.Add(robot);
    }
    input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
}
string idChecker = Console.ReadLine();
foreach (var entity in entities)
{
    if(FakeId(entity.Id, idChecker))
        Console.WriteLine(entity.Id);
}

static bool FakeId(string id, string idChecker)
{
    if (id.EndsWith(idChecker)) return true;
    else return false;
}