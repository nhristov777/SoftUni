namespace Wardrobe
{
    public class Something
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            //Blue -> dress,jeans,hat
            for (int i = 0; i < n; i++)
            {
                string[] clothing = Console.ReadLine()
                    .Split(new string[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                //clothing[0] is always colour, everything after is clothes
                string colour = clothing[0];
                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                    CheckClothing(wardrobe, clothing);
                }
                else CheckClothing(wardrobe, clothing);
            }
            //last task
            string[] task = Console.ReadLine().Split();
            string findColour = task[0];
            string findClothing = task[1];
            //print
            foreach (var (colour, clothes) in wardrobe)
            {
                Console.WriteLine($"{colour} clothes:");
                foreach (var (clothing, count) in clothes)
                {
                    if (findColour == colour && findClothing == clothing)
                        Console.WriteLine($"* {clothing} - {count} (found!)");
                    else Console.WriteLine($"* {clothing} - {count}");
                }
            }
        }
        public static void CheckClothing(Dictionary<string, Dictionary<string, int>> wardrobe
            , string[] clothing)
        {
            string colour = clothing[0];
            for (int k = 1; k < clothing.Length; k++)
            {
                if (!wardrobe[colour].ContainsKey(clothing[k]))
                { wardrobe[colour].Add(clothing[k], 1); }
                else wardrobe[colour][clothing[k]]++;
            }
        }
    }
}
