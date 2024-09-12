namespace InvoiceApp;

class Program
{
    static void Main()
    {
        Invoice invoice = new(2935678);

        Console.WriteLine(invoice.ToString());

        /* Invoice base information */
        
        /* Sender information */
        invoice.SenderName = "Company #3";
        invoice.SenderAddress = "456 Elm St";
        invoice.SenderPostalCode = "987 65";
        invoice.SenderCity = "Thattown";
        invoice.SenderPhoneNumber = "555-555-5555";
        invoice.SenderReference = "Hjonh Dho";
        invoice.SenderReferenceEmail = "Hjonhdho@company#3.com";

        /* Invoice */
        try
        {
            invoice.AddInvoiceItem(new InvoiceItem(new Product(1), numberOfItems: 1));
            invoice.AddInvoiceItem(new InvoiceItem(new Product(2), numberOfItems: 3));
            invoice.AddInvoiceItem(new InvoiceItem(new Product(3), numberOfItems: 901));
        }
        catch (ArgumentException error)
        {
            Console.WriteLine($"Something went wrong: {error.Message}");
        }

        foreach (var invoiceItem in invoice.InvoiceItems)
        {
            Console.WriteLine(invoiceItem);
        }

        Console.WriteLine(invoice);
    }
}