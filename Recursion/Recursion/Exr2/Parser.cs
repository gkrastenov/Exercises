using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Exercise2
{
    // Expression         := [ "NOT" ] <Boolean> { <BooleanOperator> <Boolean> } ...
    // Boolean            := <BooleanConstant> | <Expression> | "(" <Expression> ")"
    // BooleanOperator    := "And" | "Or" 
    // BooleanConstant    := "True" | "False"
    public class Parser
    {
        private readonly IEnumerator<Token> tokens;

        public Parser(IEnumerable<Token> tokens)
        {
            this.tokens = tokens.GetEnumerator();
            this.tokens.MoveNext();
        }
        public TimeSpan CodeExecute { get; set; }
        public bool Parse()
        {
            while (tokens.Current != null)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                var isNegated = tokens.Current is NegationToken;
                if (isNegated)
                    tokens.MoveNext();

                var boolean = ParseBoolean();
                if (isNegated)
                    boolean = !boolean;

                while (tokens.Current is OperandToken)
                {
                    var operand = tokens.Current;
                    if (!tokens.MoveNext())
                    {
                        throw new Exception("Missing expression after operand");
                    }
                    var nextBoolean = ParseBoolean();

                    if (operand is AndToken)
                        boolean = boolean && nextBoolean;
                    else
                        boolean = boolean || nextBoolean;

                }
                
                stopwatch.Stop();
                this.CodeExecute = stopwatch.Elapsed;
                ;
                return boolean;
            }

            throw new Exception("Empty expression");
        }

        private bool ParseBoolean()
        {
            if (tokens.Current is BooleanValueToken)
            {
                var current = tokens.Current;
                tokens.MoveNext();

                if (current is TrueToken)
                    return true;

                return false;
            }
            if (tokens.Current is OpenParenthesisToken)
            {
                tokens.MoveNext();

                var expInPars = Parse();

                if (!(tokens.Current is ClosedParenthesisToken))
                    throw new Exception("Expecting Closing Parenthesis");

                tokens.MoveNext();

                return expInPars;
            }
            if (tokens.Current is ClosedParenthesisToken)
                throw new Exception("Unexpected Closed Parenthesis");

            // since its not a BooleanConstant or Expression in parenthesis, it must be a expression again
            var val = Parse();
            return val;
        }
        
    }
}
