﻿try
{
    int number = int.Parse(Console.ReadLine());
    if(number < 0 )
    { throw new ArgumentException("Invalid number."); }
    else
    { Console.WriteLine(Math.Sqrt(number)); }
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Goodbye.");
}



