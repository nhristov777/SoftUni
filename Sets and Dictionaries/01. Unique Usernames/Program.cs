﻿var names = new HashSet<string>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    names.Add(name);
}

Console.WriteLine(string.Join(Environment.NewLine, names));
