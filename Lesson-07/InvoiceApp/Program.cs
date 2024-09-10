namespace InvoiceApp;

class Program
{
    static void Main()
    {
        Invoice invoice = new();

        Console.WriteLine(invoice.ToString());

        /* Invoice base information */
        invoice.InvoiceNumber = 1;
        invoice.InvoiceDate = DateTime.Now;
        invoice.DueDate = DateTime.Now.AddDays(invoice.PaymentTerms);

        /* Customer information */
        invoice.CustomerNumber = 2935678;
        invoice.CustomerName = "John Doe";
        invoice.CustomerAddress = "123 Main St";
        invoice.CustomerPostalCode = "424 12";
        invoice.CustomerCity = "Anytown";
        invoice.CustomerReference = "Jane Doe";

        Console.WriteLine(invoice);
    }
}