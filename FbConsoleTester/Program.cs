using System;
using System.Threading.Tasks;
using GraphVersionHelper;

namespace FbConsoleTester
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Starting tester...\n");

            try
            {
                var t = VersionHelper.GetLatestVersionAsync();
                Task.WaitAll(t);

                Console.WriteLine("\nResult:\nVersion => " + t.Result + "\nPrevs: " + string.Join("-", t.Result.Previous));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
