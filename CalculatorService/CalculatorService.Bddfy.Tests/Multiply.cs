namespace CalculatorService.Bddfy.Tests
{
    using NUnit.Framework;
    using Shouldly;
    using TestStack.BDDfy;

    public class Multiply
    {
        private readonly Calculator calculator = new Calculator();
        private readonly Values values = new Values();

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(3.2, 2.3, 7.36)]
        [TestCase(5.5, -2, -11)]
        public void ShouldBeAbleToMultiplyTwoNumbers(decimal value1, decimal value2, decimal result)
        {
            this.Given(_ => _.GivenIHaveTwoValues(value1, value2))
                .When(_ => _.WhenIMultipleTheValues())
                .Then(_ => _.ThenIGetTheExpectedResult(result))
                .BDDfy();
        }

        private void GivenIHaveTwoValues(decimal value1, decimal value2)
        {
            values.Value1 = value1;
            values.Value2 = value2;
        }

        private void WhenIMultipleTheValues()
        {
            values.Result = calculator.Multiply(values.Value1, values.Value2);
        }

        private void ThenIGetTheExpectedResult(decimal result)
        {
            values.Result.ShouldBe(result);
        }
    }
}