namespace CalculatorService.SpecFlow.Tests
{
    using CalculatorService;
    using TechTalk.SpecFlow;

    [Binding]
    internal class MultiplySteps
    {
        private readonly Values values;
        private readonly Calculator calculator;

        internal MultiplySteps(Values values, Calculator calculator)
        {
            this.values = values;
            this.calculator = calculator;
        }

        [When(@"I multiply the values")]
        internal void WhenIMultiplyTheValues()
        {
            values.Result = calculator.Multiply(values.Value1, values.Value2);
        }
    }
}
