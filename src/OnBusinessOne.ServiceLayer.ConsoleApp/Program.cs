using OnBusinessOne.Controllers;
using System;
using System.Threading.Tasks;

namespace OnBusinessOne.ServiceLayer.ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Reversal Journal Entries";
            Console.WriteLine("Started Reversal Journal Entries");
            await new JournalEntryController().ReverseAsync();
            Console.WriteLine("Finished Reversal Journal Entries");
            Console.ReadKey();
        }
    }
}
