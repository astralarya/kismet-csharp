using System.Linq;
using System.Collections.Generic;
using Markdig;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace KismetLanguage.Parsers
{
    public class KismetParser
    {
        public static string ParseMarkdown(string input, bool outputMarkdown = true)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var document = Markdown.Parse(input);
            var texts = new List<string>();
            foreach (var item in document.Descendants())
            {
                if (item is CodeBlock codeBlock)
                {
                    texts.Add(codeBlock.Lines.ToString());
                }
                else if (item is CodeInline codeInline)
                {
                    texts.Add(codeInline.Content);
                }
            }

            if (texts.Count == 0)
            {
                return null;
            }
            var parsed = texts.Select(text => ParseText(text, outputMarkdown));
            return string.Join("\n", parsed);
        }

        public static string ParseText(string input, bool outputMarkdown = true)
        {
            var result = input;
            if (outputMarkdown)
            {
                return $"```\n{result}\n```";
            }
            else
            {
                return result;
            }
        }
    }
}
