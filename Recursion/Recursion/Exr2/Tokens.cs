using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public abstract class Token
    {

    }

    public class OperandToken : Token
    {

    }
    public class OrToken : OperandToken
    {
    }

    public class AndToken : OperandToken
    {
    }

    public class BooleanValueToken : Token
    {

    }

    public class FalseToken : BooleanValueToken
    {
    }

    public class TrueToken : BooleanValueToken
    {
    }

    public class ParenthesisToken : Token
    {

    }

    public class ClosedParenthesisToken : ParenthesisToken
    {
    }


    public class OpenParenthesisToken : ParenthesisToken
    {
    }

    public class NegationToken : Token
    {
    }
}
