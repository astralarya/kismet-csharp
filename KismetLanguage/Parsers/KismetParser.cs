using System;
using Markdig;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace KismetLanguage.Parsers
{
    public class KismetParser
    {
        public static string ParseMarkdown(string Text)
        {
            Console.WriteLine("foo");
            var document = Markdown.Parse(Text);
            foreach (var item in document)
            {
                Console.WriteLine(item);
            }
            return "";
        }
    }
}
