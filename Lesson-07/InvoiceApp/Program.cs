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
        var item = new { ProductName = "F/A-18C Hornet", Price=33500000.00, Amount = 1, LineSum = 33500000.00};
        invoice.AddInvoiceItem(item);
        item = new { ProductName = "F-22 Raptor", Price = 190000000.00, Amount = 3, LineSum = 570000000.00};
        invoice.AddInvoiceItem(item);

        foreach(dynamic invoiceItem in invoice.InvoiceItems)
        {
            Console.WriteLine($"Product: {invoiceItem.ProductName}, Price: {invoiceItem.Price:N2}, Amount: {invoiceItem.Amount}, Line Sum: {invoiceItem.LineSum:N2}");
        }

        Console.WriteLine(invoice);
    }
}