using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercise2
{
    public class Tokenizer
    {
        private readonly StringReader reader;
        private string text;

        public Tokenizer(string text)
        {
            this.text = text;
            reader = new StringReader(text);
        }

        public IEnumerable<Token> Tokenize()
        {
            var tokens = new List<Token>();
            while (reader.Peek() != -1)
            {
                while (Char.IsWhiteSpace((char)reader.Peek()))
                {
                    reader.Read();
                }

                if (reader.Peek() == -1)
                    break;

                var c = (char)reader.Peek();
                switch (c)
                {
                    case '(':
                        tokens.Add(new OpenParenthesisToken());
                        reader.Read();
                        break;
                    case ')':
                        tokens.Add(new ClosedParenthesisToken());
                        reader.Read();
                        break;
                    default:
                        if (Char.IsLetter(c))
                        {
                            var token = ParseKeyword();
                            tokens.Add(token);
                        }
                        else
                        {
                            var remainingText = reader.ReadToEnd() ?? string.Empty;
                            throw new Exception(string.Format("Unknown grammar found at position {0} : '{1}'", text.Length - remainingText.Length, remainingText));
                        }
                        break;
                }
            }
            return tokens;
        }

        private Token ParseKeyword()
        {
            var text = new StringBuilder();
            while (Char.IsLetter((char)reader.Peek()))
            {
                text.Append((char)reader.Read());
            }

            var potentialKeyword = text.ToString();

            switch (potentialKeyword)
            {
                case "true":
                    return new TrueToken();
                case "false":
                    return new FalseToken();
                case "and":
                    return new AndToken();
                case "or":
                    return new OrToken();
                case "not":
                    return new NegationToken();
                default:
                    throw new Exception("Expected keyword (True, False, And, Or, Not) but found " + potentialKeyword);
            }
        }
    }
}
