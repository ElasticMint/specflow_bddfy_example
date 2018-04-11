namespace CalculatorService
{
    public class Calculator
    {
        public decimal Add(decimal val1, decimal val2)
        {
            return val1 + val2;
        }

        public decimal Subtract(decimal val1, decimal val2)
        {
            return val1 - val2;
        }

        public decimal Multiply(decimal val1, decimal val2)
        {
            return val1 * val2;
        }

        public decimal Divide(decimal val1, decimal val2)
        {
            return val1 / val2;
        }
    }
}