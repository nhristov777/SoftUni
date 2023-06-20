using GenericSwapInt;

int n = int.Parse(Console.ReadLine());
var box = new Box<int>();

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    box.Add(input);
}

int[] indices = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
int index = indices[0];
int index2 = indices[1];

box.Swap(index, index2);
Console.WriteLine(box);
