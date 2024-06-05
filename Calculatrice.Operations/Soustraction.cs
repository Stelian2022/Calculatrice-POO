namespace Calculatrice.Operations
{
    public class Soustraction : Operation
    {
        public Soustraction() : base("-")
        {
        }

        public override int Calculer(int a, int b)
        {
            return a - b;
        }
    }
}