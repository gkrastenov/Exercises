using Exercise2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLogic
{
    [TestClass]
    public class AllTests
    {
        [TestMethod]
        public void Test0()
        {
            var expression = "NOT TRUE OR (FALSE AND (FALSE OR TRUE))";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(false, result);


        }
        [TestMethod]
        public void Test1()
        {
            var expression = "True AND (true or false)";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test2()
        {
            var expression = "True AND FaLse";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test3()
        {
            var expression = "not false";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test4()
        {
            var expression = "not false and true";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test5()
        {
            var expression = "(not false and true)";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test6()
        {
            var expression = "(true)";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test7()
        {
            var expression = "not true and ( true and (false or false))";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test8()
        {
            var expression = "(not not true)";
            var tokens = new Tokenizer(expression.ToLower()).Tokenize();
            var parser = new Parser(tokens);
            var result = parser.Parse();

            Assert.AreEqual(true, result);
        }


    }
}
