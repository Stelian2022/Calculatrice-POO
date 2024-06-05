namespace Calculatrice.Operations
{
    public class Addition : Operation
    {
        public Addition() : base("+")
        {
        }

        public override decimal Calculer(int a, int b)
        {
            return a + b;
        }
    }
}