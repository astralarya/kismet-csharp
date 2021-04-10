using KismetLanguage.Grammar;
using KismetLanguage.Runtime;

namespace KismetLanguage.Visitors
{
    class KismetVisitorResult
    {
        public readonly object Value;
        public readonly string Summary;

        public KismetVisitorResult(object value, string summary)
        {
            Value = value;
            Summary = summary;
        }
    }

    class KismetVisitor : KismetParserBaseVisitor<KismetVisitorResult>
    {
        private SymbolTable _symbolTable = new SymbolTable();


    }
}