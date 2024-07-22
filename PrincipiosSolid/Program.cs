using PrincipiosSolid;

Document document = new Document { Name = "Programacion II", Description = "Tarea de Principios Solid de Dalbert Sanchez Reyes matricula: 20230213" };


ISimplePrinter printer = new SimplePrinter();
printer.Print(document);

IMultifunctionPrinter multifunctionPrinter = new MultifunctionPrinter();
multifunctionPrinter.Scan(document);
multifunctionPrinter.Print(document);
