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
    public Sender Sender { get; set; }

    /* Constructors */
    public Invoice(int customerNumber)
    {
        Customer = new Customer(customerNumber);
        Sender = new Sender();

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
        return $"{Sender}\n{Customer}\nInvoice Number: {InvoiceNumber} - Invoice Date: {InvoiceDate} - Due Date: {DueDate}\nTotal Value: ${TotalValue:N2}";
    }
    
}