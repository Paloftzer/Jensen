namespace InvoiceApp;

public class Customer : Company
{
    /* Properties */
    public int CustomerNumber { get; set; }

    public int PaymentTerms { get; set; } = 30;

    public Address InvoiceAddress { get; set; } = new Address();

    /* Constructors */
    public Customer() {}

    public Customer(int customerNumber)
    {
        CustomerNumber = customerNumber;
        Find();

        PaymentTerms = 60;
    }

    /* Methods */
    public override string ToString()
    {
        return $"Customer name: {Name} - Address: {Address} - Invoice Address {InvoiceAddress} - Payment Terms: {PaymentTerms} days - Reference: {Reference}";
    }

    /* Private Methods */
    public override void Find()
    {
        Name = "John Doe";
        Address.AddressLine = "123 Main St";
        Address.PostalCode = "424 12";
        Address.City = "Anytown";
        Reference = "Jane Doe";

        // Invoice Address
        InvoiceAddress.AddressLine = "321 Niam St";
        InvoiceAddress.PostalCode = "214 24";
        InvoiceAddress.City = "Anytown";
    }
}