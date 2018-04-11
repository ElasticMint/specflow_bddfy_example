namespace CalculatorService.SpecFlow.Tests
{
    using CalculatorService;
    using TechTalk.SpecFlow;

    [Binding]
    internal class DivideSteps
    {
        private readonly Values values;
        private readonly Calculator calculator;

        internal DivideSteps(Values values, Calculator calculator)
        {
            this.values = values;
            this.calculator = calculator;
        }

        [When(@"I divide the first value by the second value")]
        public void WhenIDivideTheFirstValueByTheSecondValue()
        {
            values.Result = calculator.Divide(values.Value1, values.Value2);
        }
    }
}