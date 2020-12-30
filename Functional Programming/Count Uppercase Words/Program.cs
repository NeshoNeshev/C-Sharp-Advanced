using System;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> uperChecer = s => s[0] == s.ToUpper()[0];
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(uperChecer).ToArray();
            Console.WriteLine(string.Join("\n", input));
        }
    }
}
