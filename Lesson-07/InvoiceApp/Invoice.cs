namespace InvoiceApp;

public class Invoice
{
    /* Properties */

    /* Basic information */
    public int InvoiceNumber { get; }
    public DateTime InvoiceDate { get; }
    public DateTime DueDate { get; }
    public decimal TotalValue { get; private set; }
    public List<InvoiceItem> InvoiceItems { get; }
    public Customer Customer { get; set;}

    /* Sender Information */
    public string SenderName { get; set; }
    public string SenderAddress { get; set; }
    public string SenderPostalCode { get; set; }
    public string SenderCity { get; set; }
    public string SenderPhoneNumber { get; set; }
    public string SenderReference { get; set; }
    public string SenderReferenceEmail { get; set; }

    /* Constructors */
    public Invoice(int customerNumber)
    {
        /* Sender information initiation */
        Customer = new Customer(customerNumber);
        SenderName = "";
        SenderAddress = "";
        SenderPostalCode = "";
        SenderCity = "";
        SenderPhoneNumber = "";
        SenderReference = "";
        SenderReferenceEmail = "";

        /* Payment details initiation */
        InvoiceNumber = new Random().Next(100000, 999999);
        InvoiceDate = DateTime.Now.Date;
        DueDate = InvoiceDate.AddDays(Customer.PaymentTerms);

        /* Initiate list of invoice rows */
        InvoiceItems = [];
    }

    /* Methods */
    public void AddInvoiceItem(InvoiceItem invoiceItem)
    {
        InvoiceItems.Add(invoiceItem);

        TotalValue += invoiceItem.LineSum;
    }

    public override string ToString()
    {
        return $"Invoice Number: {InvoiceNumber} - Invoice Date: {InvoiceDate} - Due Date: {DueDate} - {Customer} - Total Value: {TotalValue:N2}";
    }
    
}