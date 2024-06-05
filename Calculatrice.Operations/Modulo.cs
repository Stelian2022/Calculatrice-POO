namespace Calculatrice.Operations
{
    public class Modulo : Operation
    {
        public Modulo() : base("%")
        {
        }

        public override int Calculer(int a, int b)
        {
            return a % b;
        }
    }
}