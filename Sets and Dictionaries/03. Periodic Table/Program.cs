int n = int.Parse(Console.ReadLine());
var compounds = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string[] compound = Console.ReadLine().Split(" ");
    for (int k = 0; k < compound.Length; k++)
        compounds.Add(compound[k]);
}
compounds = compounds.OrderBy(x => x).ToHashSet();
Console.WriteLine(String.Join(" ", compounds));