int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = lengths[0];
int m = lengths[1];
var nSet = new HashSet<int>();
var mSet = new HashSet<int>();
//n and m sets
for (int i = 0; i < n; i++)
{ 
    int num = int.Parse(Console.ReadLine());
    nSet.Add(num);
}
for (int i = 0; i < m; i++)
{
    int num = int.Parse(Console.ReadLine());
    mSet.Add(num);
}
//add unique
var unique = new HashSet<int>();
foreach (var iten in nSet)
{
    foreach (var item in mSet)
    {
        if(iten == item) unique.Add(iten);
    }
}

Console.WriteLine(String.Join(" ", unique));