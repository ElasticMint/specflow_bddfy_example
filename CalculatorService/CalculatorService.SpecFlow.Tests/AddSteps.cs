namespace CalculatorService.SpecFlow.Tests
{
    using CalculatorService;
    using TechTalk.SpecFlow;

    [Binding]
    internal class AddSteps
    {
        private readonly Values values;
        private readonly Calculator calculator;

        internal AddSteps(Values values, Calculator calculator)
        {
            this.values = values;
            this.calculator = calculator;
        }

        [When(@"I add the values")]
        internal void WhenIAddTheValues()
        {
            values.Result = calculator.Add(values.Value1, values.Value2);
        }
    }
}
