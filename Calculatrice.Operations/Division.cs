namespace Calculatrice.Operations
{
    public class Division : Operation
    {
        public Division() : base("/")
        {
        }

        public override int Calculer(int a, int b)
        {
            return a / b;
        }
    }
}