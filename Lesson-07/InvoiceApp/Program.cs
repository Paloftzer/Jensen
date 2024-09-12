namespace InvoiceApp;

class Program
{
    static void Main()
    {
        Invoice invoice = new(2935678);

        /* Invoice */
        try
        {
            invoice.AddInvoiceItem(new InvoiceItem(new Product(1), numberOfItems: 1));
            invoice.AddInvoiceItem(new InvoiceItem(new Product(2), numberOfItems: 3));
            // Intentional simulated error
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