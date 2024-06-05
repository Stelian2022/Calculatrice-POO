namespace Calculatrice.Operations
{
    public class Addition : Operation
    {
        public Addition() : base("+")
        {
        }

        public override int Calculer(int a, int b)
        {
            return a + b;
        }
    }
}