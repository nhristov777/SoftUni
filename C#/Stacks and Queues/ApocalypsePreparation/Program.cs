int[] textileToken = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
Queue<int> textiles = new(textileToken);

int[] medsToken = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
Stack<int> meds = new(medsToken);

var medicaments = new Dictionary<string, int>();
string item = string.Empty;
int sum = 0;
int currMeds = 0;
while (meds.Count > 0 && textiles.Count > 0)
{
    currMeds += meds.FirstOrDefault();
    int currTextiles = textiles.FirstOrDefault();
    sum += currMeds + currTextiles;

    if (sum == 30)
    {
        item = "Patch"; sum = 0; currMeds = 0;
        meds.Pop(); textiles.Dequeue();
    }
    else if (sum == 40)
    {
        item = "Bandage"; sum = 0; currMeds = 0;
        meds.Pop(); textiles.Dequeue();
    }
    else if (sum == 100)
    {
        item = "MedKit"; sum = 0;
        currMeds = 0;
        meds.Pop(); textiles.Dequeue();

    }
    else if (sum > 100)
    {
        item = "MedKit";
        textiles.Dequeue();
        meds.Pop();
        meds.Push(meds.Pop() + (sum - 100));
        currMeds = 0;
        sum = 0;
    }
    else
    {
        textiles.Dequeue();
        meds.Push(meds.Pop() + 10);
        sum = 0; currMeds = 0;
        item = "None";
    }

    AddItems(item, medicaments);
}

if (textiles.Count == 0 && meds.Count == 0)
    Console.WriteLine("Textiles and medicaments are both empty.");
else if (textiles.Count == 0)
    Console.WriteLine("Textiles are empty.");
else if (meds.Count == 0)
    Console.WriteLine("Medicaments are empty.");

medicaments = medicaments.OrderByDescending
    (c => c.Value).ThenBy(c => c.Key).ToDictionary(c => c.Key, c => c.Value);

foreach (var purchase in medicaments)
{ Console.WriteLine($"{purchase.Key} - {purchase.Value}"); }


if (textiles.Count == 0 && meds.Count == 0)
{ return; }
else if (textiles.Count == 0)
    Console.WriteLine($"Medicaments left: {string.Join(", ", meds)}");
else if (meds.Count == 0)
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");

static void AddItems(string item, Dictionary<string, int> medicaments)
{
    switch (item)
    {
        case "Patch":
            if (!medicaments.ContainsKey("Patch"))
            { medicaments.Add("Patch", 1); }
            else medicaments["Patch"]++;
            break;
        case "Bandage":
            if (!medicaments.ContainsKey("Bandage"))
            { medicaments.Add("Bandage", 1); }
            else medicaments["Bandage"]++;
            break;
        case "MedKit":
            if (!medicaments.ContainsKey("MedKit"))
            { medicaments.Add("MedKit", 1); }
            else medicaments["MedKit"]++;
            break;
        default: break;
    }
}