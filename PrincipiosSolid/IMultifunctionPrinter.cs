namespace PrincipiosSolid
{
    public interface IMultifunctionPrinter : ISimplePrinter
    {
        void Scan(Document document);
    }
}
