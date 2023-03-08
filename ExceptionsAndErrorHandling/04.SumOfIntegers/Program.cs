string[] inputTokens = Console.ReadLine().Split();
List<int> array = new();
foreach (var input in inputTokens)
{
    try
    {
        int number = int.Parse(input);
        array.Add(number);
    }
    catch (FormatException)
    { Console.WriteLine($"The element '{input}' is in wrong format!"); }
    catch (OverflowException)
    { Console.WriteLine($"The element '{input}' is out of range!"); }
    finally { Console.WriteLine($"Element '{input}' processed - current sum: {array.Sum()}"); }
}
Console.WriteLine($"The total sum of all integers is: {array.Sum()}");