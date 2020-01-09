using NUnit.Framework;

namespace Calculator.Library.Tests
{

    [TestFixture]
    public class CalculatorTests
    {

        [Test]
        public void ParseAtomOperation()
        {
            const string expression = "63";
            Calculator calc = new Calculator();
            var operation = calc.Evaluate(expression);
            Assert.AreEqual(63, operation);
        }

        [Test]
        public void GetAddOperationTypeAndRightResultWhenParseAddExpressions()
        {
            const string expression = "6+3";
            const string expression2 = "6+3+2";
            Calculator calc = new Calculator();

            var operation = calc.Evaluate(expression);

            Assert.AreEqual(9, operation);

            var operation2 = calc.Evaluate(expression2);

            Assert.AreEqual(11, operation2);
        }

        [Test]
        public void GetSubtractOperationTypeAndRightResultWhenParseSubtractExpression()
        {
            const string expression = "6-3";
            const string expression2 = "6-3-2";
            Calculator calc = new Calculator();

            var operation = calc.Evaluate(expression);
            Assert.AreEqual(3, operation);

            var operation2 = calc.Evaluate(expression2);
            Assert.AreEqual(1, operation2);
        }

        [Test]
        public void AddAndSubtructOperationsCalulate()
        {
            const string expression = "(6-3-5)";
            const string expression2 = "6-(3-2)+5";
            const string expression3 = "(6+5)-(3-2)";
            const string expression4 = "6-(2*(3-2))";
            Calculator calc = new Calculator();

            var operation = calc.Evaluate(expression);
            var operation2 = calc.Evaluate(expression2);
            var operation3 = calc.Evaluate(expression3);
            var operation4 = calc.Evaluate(expression4);

            Assert.AreEqual(-2, operation);
            Assert.AreEqual(10, operation2);
            Assert.AreEqual(10, operation3);
            Assert.AreEqual(4, operation4);
        }

        [Test]
        public void GetMultipleOperationTypeAndRightResultWhenParseMultipleExpression()
        {
            const string expression = "6*3";
            Calculator calc = new Calculator();
            var operation = calc.Evaluate(expression);
            Assert.AreEqual(18, operation);
        }

        [Test]
        public void GetAddOperationTypeAndRightResultWhenParseExpressionWithAddAndMultipleOperations()
        {
            const string expression = "2+6*3";
            const string expression2 = "6*3+2";
            Calculator calc = new Calculator();

            var operation = calc.Evaluate(expression);

            Assert.AreEqual(20, operation);

            var operation2 = calc.Evaluate(expression2);

            Assert.AreEqual(20, operation2);
        }

        [Test]
        public void BracesInExpressionHaveHighestPriority()
        {
            const string expression = "(2+6)*3";
            const string expression2 = "6*(3+2)";
            Calculator calc = new Calculator();

            var operation = calc.Evaluate(expression);
            Assert.AreEqual(24, operation);
            var operation2 = calc.Evaluate(expression2);
            Assert.AreEqual(30, operation2);
        }

        [Test]
        public void MultipleAndDivideOperationsCalulate()
        {
            const string expression = "6*5/3";
            const string expression2 = "50/5/5";
            const string expression3 = "(4*4)-(3*3)";
            const string expression4 = "50/(5/5)";
            Calculator calc = new Calculator();

            var operation = calc.Evaluate(expression);
            var operation2 = calc.Evaluate(expression2);
            var operation3 = calc.Evaluate(expression3);
            var operation4 = calc.Evaluate(expression4);

            Assert.AreEqual(10, operation);
            Assert.AreEqual(2, operation2);
            Assert.AreEqual(7, operation3);
            Assert.AreEqual(50, operation4);
        }
    }
}

