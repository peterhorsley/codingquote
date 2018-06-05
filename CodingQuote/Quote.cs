using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingQuote
{
    public class Quote
    {
        public Quote(string text, string source)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("text");
            }
            if (String.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentException("source");
            }

            Text = text;
            Source = source;
        }

        public string Text { get; private set; }
        public string Source { get; private set; }

        public override string ToString()
        {
            return String.Format("{0}\n{1}", Text, Source);
        }
    }
}
