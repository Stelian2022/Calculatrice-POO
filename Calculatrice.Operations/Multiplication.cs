namespace Calculatrice.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication() : base("*")
        {
        }

        public override decimal Calculer(int a, int b)
        {
            return a * b;
        }
      
    }
}