/// <summary>
///  Draft
/// </summary>

namespace Draft
{
    internal class Program
    {
        static void Main()
        {
            List<KeyValuePair<char, byte>> pairs = new();
            Dictionary<char, byte> dic = new(pairs);
            List<string> names = new();
            names.AddRange(["Tsvetelin", "Maria", "Antonia"]);
            bool hasMan = names.Exists(name => name.EndsWith("in"));
            Console.WriteLine(hasMan);
            string? mansName = names.Find(name => name.StartsWith("Ts") && name.EndsWith("in"));
            Console.WriteLine(mansName);
        }
    }
}
