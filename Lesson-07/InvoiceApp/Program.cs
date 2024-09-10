﻿namespace InvoiceApp;

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
        var item = new InvoiceItem();
        item.AddProduct(productId:1, productName:"F/A-18C Hornet", price:33500000.00m, amount:1);
        invoice.AddInvoiceItem(item);
        item = new();
        item.AddProduct(productId:2, productName:"F-22 Raptor", price:190000000.00m, amount:3);
        invoice.AddInvoiceItem(item);

        foreach(var invoiceItem in invoice.InvoiceItems)
        {
            Console.WriteLine(invoiceItem);
        }

        Console.WriteLine(invoice);
    }
}