﻿namespace InvoiceApp;

public class Invoice
{
    /* Basic information */
    public int InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal TotalValue { get; set; }

    /* Sender Information */
    public string SenderName { get; set; }
    public string SenderAddress { get; set; }
    public string SenderPostalCode { get; set; }
    public string SenderCity { get; set; }
    public string SenderPhoneNumber { get; set; }
    public string SenderReference { get; set; }
    public string SenderReferenceEmail { get; set; }

    /* Customer Information */
    public int CustomerNumber { get; set; }
    public string CustomerName { get; set; }
    public string CustomerAddress { get; set; }
    public string CustomerPostalCode { get; set; }
    public string CustomerCity { get; set; }
    public string CustomerReference { get; set; }

    public int PaymentTerms { get; set; }

    /* Constructors */
    public Invoice()
    {
        /* Sender information initiation */
        SenderName = "";
        SenderAddress = "";
        SenderPostalCode = "";
        SenderCity = "";
        SenderPhoneNumber = "";
        SenderReference = "";
        SenderReferenceEmail = "";

        /* Customer information initiation */
        CustomerName = "";
        CustomerAddress = "";
        CustomerPostalCode = "";
        CustomerCity = "";
        CustomerReference = "";
    }

    /* Methods */
    public override string ToString()
    {
        return $"Invoice Number; {InvoiceNumber} - Invoice Date: {InvoiceDate} - Due Date: {DueDate} - Customer: {CustomerName}";
    }
}