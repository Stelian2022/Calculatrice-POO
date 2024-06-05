namespace Calculatrice.Operations
{
    public class Division : Operation
    {
        public Division() : base("/")
        {
        }

        public override decimal Calculer(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return a / b;
        }
       
    }
}