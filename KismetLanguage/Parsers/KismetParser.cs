using System;
using System.Collections.Generic;
using Markdig;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace KismetLanguage.Parsers
{
    public class KismetParser
    {
        public static string ParseMarkdown(string Text)
        {
            if (string.IsNullOrEmpty(Text))
            {
                return null;
            }

            var document = Markdown.Parse(Text);
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
            return "";
        }
    }
}
