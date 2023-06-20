string text = Console.ReadLine();
var letters = new SortedDictionary<char, int>();
foreach (var letter in text)
{
    if (!letters.ContainsKey(letter))
    { letters.Add(letter, 1); }
    else letters[letter]++;
}
foreach (var (letter, count) in letters)
{
    Console.WriteLine($"{letter}: {count} time/s");
}