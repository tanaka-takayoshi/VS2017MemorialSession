using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = Path.GetTempFileName();
            File.WriteAllText(path, "Hello Temp File!");
            Console.WriteLine($"Wrote temp file: {path}");
        }
    }
}
