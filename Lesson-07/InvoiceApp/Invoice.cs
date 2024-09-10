using System.Reflection;
using System.Reflection.Metadata;

namespace InvoiceApp;

public class Invoice
{
    /* Basic information */
    public int InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal TotalValue { get; set; }
    public int PaymentTerms { get; set; }
    public List<object> InvoiceItems { get; set; }

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

        /* Payment details initiation */
        InvoiceNumber = new Random().Next(100000, 999999);
        InvoiceDate = DateTime.Now;
        PaymentTerms = 30;
        DueDate = InvoiceDate.AddDays(PaymentTerms);

        /* Initiate list of invoice rows */
        InvoiceItems = [];
    }

    /* Methods */
    public void AddInvoiceItem(object invoiceItem)
    {
        InvoiceItems.Add(invoiceItem);

        // Don't use this but it works
        /* var t = invoiceItem.GetType();
        PropertyInfo[] properties = t.GetProperties();
        foreach (var property in properties)
        {
            if (property.Name == "LineSum")
            {
                var lineSum = property.GetValue(invoiceItem);
                TotalValue += Convert.ToDecimal(lineSum);
            }
        } */
    }

    public override string ToString()
    {
        return $"Invoice Number; {InvoiceNumber} - Invoice Date: {InvoiceDate} - Due Date: {DueDate} - Customer: {CustomerName} - Total Value: {TotalValue:N2}";
    }
    
}