namespace Calculatrice.Operations
{
    public class Modulo : Operation
    {
        public Modulo() : base("%")
        {
        }

        public override decimal Calculer(int a, int b)
        {
            return a % b;
        }


    }
}