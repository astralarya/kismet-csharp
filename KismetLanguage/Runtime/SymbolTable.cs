using System.Collections.Generic;

namespace KismetLanguage.Runtime
{
    class UndefinedSymbol { }

    class SymbolTable
    {
        private Stack<Dictionary<string, object>> _symbols
            = new Stack<Dictionary<string, object>>(
                new[] {
                    new Dictionary<string, object>(),
                }
            );

        public void PushScope()
        {
            _symbols.Push(new Dictionary<string, object>());
        }

        public void PopScope()
        {
            _symbols.Pop();
        }

        public object GetSymbol(string key)
        {
            foreach (var frame in _symbols)
            {
                if(frame.ContainsKey(key))
                {
                    return frame[key];
                }
            }
            return new UndefinedSymbol();
        }

        public void SetSymbol(string key, object value)
        {
            _symbols.Peek()[key] = value;
        }
    }
}
