using System.Runtime.CompilerServices;

namespace Csharp9NewFeatures
{
    internal class Program
    {
        static string Message;
        [ModuleInitializer]
        public static void Init()
        {
            Message = "Hello World!";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!" + Message);
        }
    }
}
