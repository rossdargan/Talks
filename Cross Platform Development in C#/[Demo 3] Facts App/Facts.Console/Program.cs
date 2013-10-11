using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facts.Domain.Entities;
using Facts.Domain.Service;
using Facts.Repository;

namespace Facts.Console
{
    class Program
    {
        private static void Main(string[] args)
        {
            FactService factService = new FactService(new CNRepository());

            string input = "";
            while (input != "n")
            {
                PrintFact(factService);
                input = System.Console.ReadLine();
            }

        }

        private static async void PrintFact(FactService factService)
        {
            var fact = await factService.GetRandomFact();
            System.Console.WriteLine(fact.TheFact);
        }
    }
}
