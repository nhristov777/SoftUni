int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
int exceptions = 0;
while (exceptions < 3)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string cmd = input[0];
    try
    {
        int index1 = int.Parse(input[1]);
        if (cmd == "Replace")
        {
            int index2 = int.Parse(input[2]);
            Replace(index1, index2, numbers);
        }
        else if (cmd == "Print")
        {
            int index2 = int.Parse(input[2]);
            Print(index1, index2, numbers);
        }
        else Show(index1, numbers);
    }
    catch (ArgumentOutOfRangeException)
    { Console.WriteLine("The index does not exist!"); exceptions++; }
    catch (IndexOutOfRangeException)
    { Console.WriteLine("The index does not exist!"); exceptions++; }
    catch (FormatException)
    { Console.WriteLine("The variable is not in the correct format!"); exceptions++; }
}
Console.WriteLine(String.Join(", ", numbers));

static void Replace(int index, int element, int[] numbers)
{ numbers[index] = element; }
static void Print(int startIndex, int endIndex, int[] numbers)
{
    Queue<int> intElements = new();
    for (int i = startIndex; i <= endIndex; i++)
        intElements.Enqueue(numbers[i]);
    Console.WriteLine(String.Join(", ", intElements));
}
static void Show(int index, int[] numbers)
{ Console.WriteLine(numbers[index]); }
