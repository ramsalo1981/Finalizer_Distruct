using System;

namespace CAFinalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // N: number with ,00 with space between 3numbers <=> 999 999,89
            // N0: number without ,00 with space between 3numbers <=> 999 999
            MakeSomGarbage();
            Console.WriteLine($"Memory used before Collecion: {GC.GetTotalMemory(false):N0}");
            GC.Collect();
            Console.WriteLine($"Memory used after collection: {GC.GetTotalMemory(true):N}");
        }
        static void MakeSomGarbage()
        {
            Version v;
            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }
    }

    
}