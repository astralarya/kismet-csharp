using System.Linq;
using System.Collections.Generic;
using Markdig;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace KismetLanguage.Parsers
{
    public class KismetParser
    {
        public static string Parse(string input, bool outputTree = true)
        {
            var stream = CharStreams.fromString(input);
            var lexer = new Grammar.KismetLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new Grammar.KismetParser(tokens);
            parser.BuildParseTree = true;
            var tree = parser.start();

            if (outputTree)
            {
                return tree.ToStringTree(parser.RuleNames);
            }
            else
            {
                return null;
            }
        }

        public static string ParseText(string input, bool outputMarkdown = false)
        {
            var result = Parse(input);

            if (outputMarkdown)
            {
                return $"```\n{result}\n```";
            }
            else
            {
                return result;
            }
        }

        public static string ParseMarkdown(string input, bool outputMarkdown = false)
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

    }
}
