using System;

namespace softAdvanced
{
    internal class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> checker = x => x % n == 0;
            for (int i = 0; i < nums.Count; i++)
                if (checker(nums[i])) { nums.Remove(nums[i]); i--; }

            nums.Reverse();
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}

