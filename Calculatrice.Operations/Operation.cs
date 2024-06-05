namespace Calculatrice.Operations
{
    public abstract class Operation
    {
        public string Symbole { get; }

        protected Operation(string symbole)
        {
            Symbole = symbole;
        }

        public abstract int Calculer(int a, int b);
    }
}
