namespace InvoiceApp;

class Program
{
    static void Main()
    {
        Invoice invoice = new();

        Console.WriteLine(invoice.ToString());

        /* Invoice base information */

        /* Customer information */
        invoice.CustomerNumber = 2935678;
        invoice.CustomerName = "John Doe";
        invoice.CustomerAddress = "123 Main St";
        invoice.CustomerPostalCode = "424 12";
        invoice.CustomerCity = "Anytown";
        invoice.CustomerReference = "Jane Doe";

        /* Sender information */
        invoice.SenderName = "Company #3";
        invoice.SenderAddress = "456 Elm St";
        invoice.SenderPostalCode = "987 65";
        invoice.SenderCity = "Thattown";
        invoice.SenderPhoneNumber = "555-555-5555";
        invoice.SenderReference = "Hjonh Dho";
        invoice.SenderReferenceEmail = "Hjonhdho@company#3.com";

        /* Invoice */
        // Product product = new();
        // product.ItemNumber = 1;
        // product.Name = "F/A-18C Hornet";
        // product.Price = 33500000.00m;

        // InvoiceItem item = new InvoiceItem(product, 1);
        // invoice.AddInvoiceItem(item);

        // product = new()
        // {
        //     ItemNumber = 2,
        //     Name = "F-22 Raptor",
        //     Price = 190000000.00m
        // };

        // item = new InvoiceItem(product, 3);
        // invoice.AddInvoiceItem(item);

        // InvoiceItem item = new InvoiceItem(new Product { ItemNumber = 1, Name = "F/A-18C Hornet", Price = 33500000.00m }, 1);
        // invoice.AddInvoiceItem(item);

        // item = new InvoiceItem(new Product { ItemNumber = 2, Name = "F-22 Raptor", Price = 190000000.00m }, 3);
        // invoice.AddInvoiceItem(item);

        invoice.AddInvoiceItem(new InvoiceItem(new Product { ItemNumber = 1, Name = "F/A-18C Hornet", Price = 33500000.00m }, 1));
        invoice.AddInvoiceItem(new InvoiceItem(new Product { ItemNumber = 2, Name = "F-22 Raptor", Price = 190000000.00m }, 1));

        foreach(var invoiceItem in invoice.InvoiceItems)
        {
            Console.WriteLine(invoiceItem);
        }

        Console.WriteLine(invoice);
    }
}