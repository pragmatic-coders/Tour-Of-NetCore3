using System;
using System.IO;
using System.Linq;

namespace Sample_CSV_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            // var csv = @"Year,Title,Production Studio
            //         2008,Iron Man,Marvel Studios
            //         2008,The Incredible Hulk,Marvel Studios
            //         2009,X-Men Origins:Wolverine,20th Century Fox
            //         2010,Iron Man 2,Marvel Studios
            //         2011,Thor,Marvel Studios
            //         2011,X-Men:First Class,20th Century Fox";


            // var sr = new StringReader(csv);
            // var csvReader = new CsvReader(sr);
            var reader = new StreamReader(new FileStream("Marvel.csv", FileMode.Open));
            var csvReader = new CsvReader(reader);
            foreach (var item in csvReader.Lines)
            {
                Console.WriteLine(item.First(i => i.Key == "Title").Value);
            }
        }
    }
}
