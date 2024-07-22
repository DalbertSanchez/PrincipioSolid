using PrincipiosSolid;


Document document = new Document();



IPrinter printer = new SimplePrinter();

printer.Print(document);


IMultifunctionPrinter multifunctionPrinter = new MultifunctionPrinter();
multifunctionPrinter.Scan(document);
multifunctionPrinter.Print(document);
