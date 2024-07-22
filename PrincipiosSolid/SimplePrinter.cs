namespace PrincipiosSolid
{
    public class SimplePrinter : ISimplePrinter
    {
        public void Print(Document document)
        {
            Console.WriteLine("********** Simple Printer **********");
            Console.WriteLine($"\n\nImprimiendo documento {document.Name} desde la impresora simple\n\n");
            Console.WriteLine("*************************************\n\n\n");

        }
    }
}
