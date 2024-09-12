namespace InvoiceApp;

public class Customer
{
    /* Properties */
    public int CustomerNumber { get; set; }
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
    public string Reference { get; set; } = "";

    public int PaymentTerms { get; set; } = 30;

    /* Constructors */
    public Customer() {}

    public Customer(int customerNumber)
    {
        CustomerNumber = customerNumber;
        FindCustomer();

        PaymentTerms = 60;
    }

    /* Methods */
    public override string ToString()
    {
        return $"Customer name: {Name} - Address: {Address}, {PostalCode}, {City} - Payment Terms: {PaymentTerms} days - Reference: {Reference}";
    }

    /* Private Methods */
    private void FindCustomer()
    {

        Name = "John Doe";
        Address = "123 Main St";
        PostalCode = "424 12";
        City = "Anytown";
        Reference = "Jane Doe";

    }
}
