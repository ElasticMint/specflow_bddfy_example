namespace CalculatorService.SpecFlow.Tests
{
    using Shouldly;
    using TechTalk.SpecFlow;

    [Binding]
    internal class CommonSteps
    {
        private readonly Values values;

        internal CommonSteps(Values values)
        {
            this.values = values;
        }

        [Given(@"values (.*) and (.*)")]
        internal void GivenValuesAnd(decimal value1, decimal value2)
        {
            values.Value1 = value1;
            values.Value2 = value2;
        }

        [Then(@"the result should be (.*)")]
        internal void ThenTheResultShouldBe(decimal result)
        {
            values.Result.ShouldBe(result);
        }
    }
}