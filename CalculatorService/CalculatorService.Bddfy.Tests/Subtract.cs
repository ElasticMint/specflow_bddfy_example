﻿namespace CalculatorService.Bddfy.Tests
{
    using NUnit.Framework;
    using Shouldly;
    using TestStack.BDDfy;

    internal class Subtract
    {
        private readonly Calculator calculator = new Calculator();
        private readonly Values values = new Values();

        [Test]
        [TestCase(1, 1, 0)]
        [TestCase(3.2, 2.3, 0.9)]
        [TestCase(5.5, 6.6, -1.1)]
        public void ShouldBeAbleToSubtractTwoNumbers(decimal value1, decimal value2, decimal result)
        {
            this.Given(_ => _.GivenIHaveTwoValues(value1, value2))
                .When(_ => _.WhenISubtractTheSecondValueFromTheFirstValue())
                .Then(_ => _.ThenIGetTheExpectedResult(result))
                .BDDfy();
        }

        private void GivenIHaveTwoValues(decimal value1, decimal value2)
        {
            values.Value1 = value1;
            values.Value2 = value2;
        }

        private void WhenISubtractTheSecondValueFromTheFirstValue()
        {
            values.Result = calculator.Subtract(values.Value1, values.Value2);
        }

        private void ThenIGetTheExpectedResult(decimal result)
        {
            values.Result.ShouldBe(result);
        }
    }
}