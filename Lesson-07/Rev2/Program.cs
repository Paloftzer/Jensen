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

        // Create a fake reminder
        Reminder reminder = new(123456789);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("------------------------------------------------------------------------------------ REMINDER ------------------------------------------------------------------------------------");

        try
        {
            reminder.AddInvoiceItem(new InvoiceItem(new Product(1), numberOfItems: 1));
            reminder.AddInvoiceItem(new InvoiceItem(new Product(2), numberOfItems: 3));
        }
        catch (ArgumentException error)
        {
            
            Console.WriteLine($"Something went wrong: {error.Message}");
        }

        reminder.CalculateReminderTotal();
        Console.WriteLine(reminder.ToString());
        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.ResetColor();
    }
}