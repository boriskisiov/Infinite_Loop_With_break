using System.Data;

namespace Infinite_Loop_With_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") {
                    break;
                }
                Console.WriteLine("Executing: " + command);
            }
            
        }
    }
}