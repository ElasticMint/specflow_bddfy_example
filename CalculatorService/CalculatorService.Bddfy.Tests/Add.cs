namespace CalculatorService.Bddfy.Tests
{
    using NUnit.Framework;
    using Shouldly;
    using TestStack.BDDfy;

    public class Add
    {
        private readonly Calculator calculator = new Calculator();
        private readonly Values values = new Values();

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(1.2, 2.3, 3.5)]
        public void ShouldBeAbleToAddTwoNumbers(decimal value1, decimal value2, decimal result)
        {
            this.Given(_ => _.GivenIHaveTwoValues(value1, value2))
                .When(_ => _.WhenIAddThem())
                .Then(_ => _.ThenIGetTheExpectedResult(result))
                .BDDfy();
        }

        private void GivenIHaveTwoValues(decimal value1, decimal value2)
        {
            values.Value1 = value1;
            values.Value2 = value2;
        }

        private void WhenIAddThem()
        {
            values.Result = calculator.Add(values.Value1, values.Value2);
        }

        private void ThenIGetTheExpectedResult(decimal result)
        {
            values.Result.ShouldBe(result);
        }
    }
}
