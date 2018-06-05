using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Reflection;
using System.IO;

namespace CodingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            var quotes = new List<Quote>();

            using (var reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("CodingQuote.Quotes.txt")))
            {
                try
                {
                    while (reader.Peek() != -1)
                    {
                        quotes.Add(ReadQuote(reader));
                        reader.ReadLine();
                    }
                }
                catch (IOException) { }
            }

            var randomizer = new Random();
            int chosenQuote = randomizer.Next(quotes.Count - 1);
            Console.WriteLine(quotes[chosenQuote]);
        }

        private static Quote ReadQuote(StreamReader reader)
        {
            var text = reader.ReadLine();
            var source = reader.ReadLine();
            return new Quote(text, source);
        }
    }
}
