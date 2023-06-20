using Telephony;

string[] phoneNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] urls = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Smartphone smartphone = new();
StationaryPhone phone = new();

foreach (var number in phoneNumbers)
{
    if(number.Length == 10)
        Console.WriteLine(smartphone.Call(number));
    else Console.WriteLine(phone.Call(number)); 
}

foreach (var url in urls)
{
    Console.WriteLine(smartphone.Browse(url));
}