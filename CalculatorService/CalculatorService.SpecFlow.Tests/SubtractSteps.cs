namespace CalculatorService.SpecFlow.Tests
{
    using CalculatorService;
    using TechTalk.SpecFlow;

    [Binding]
    internal class SubtractSteps
    {
        private readonly Values values;
        private readonly Calculator calculator;

        internal SubtractSteps(Values values, Calculator calculator)
        {
            this.values = values;
            this.calculator = calculator;
        }


        [When(@"I subtract the second value from the first value")]
        internal void WhenISubtractTheSecondValueFromTheFirstValue()
        {
            values.Result = calculator.Subtract(values.Value1, values.Value2);
        }
    }
}
