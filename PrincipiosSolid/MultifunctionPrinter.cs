namespace PrincipiosSolid
{
    public class MultifunctionPrinter : IMultifunctionPrinter
    {
        public void Scan(Document document)
        {
            Console.WriteLine("********** Multifunction Printer **********");
            Console.WriteLine($"\n\nEscaniando documento {document.Name}\n");
        }

        public void Print(Document document)
        {
            Console.WriteLine($"Imprimiendo documento {document.Name} desde la impresora multifuncion\n\n");
            Console.WriteLine("***********************************************");

        }
    }
}
