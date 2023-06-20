ReadNumber();

static void ReadNumber()
{//range is 1-100
    int currNum = 1;
    List<int> array = new();
    while (array.Count < 10)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number > currNum && number < 100)
            {
                currNum = number;
                array.Add(number);
            }
            else
            { throw new ArgumentOutOfRangeException(); }
        }
        catch (FormatException)
        { Console.WriteLine("Invalid Number!"); }
        catch (ArgumentOutOfRangeException)
        { Console.WriteLine($"Your number is not in range {currNum} - 100!"); }

    }
    Console.WriteLine(String.Join(", ", array));
}
