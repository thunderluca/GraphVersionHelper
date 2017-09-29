using System;
using GraphVersionHelper;

namespace FbConsoleTester
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting tester...\n");

            var t = VersionHelper.GetLatestVersionAsync();
            t.Wait();

            Console.WriteLine($"\nResult:\nVersion => {t.Result}\nPrevs: {string.Join("-", t.Result.Previous)}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
