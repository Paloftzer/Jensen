namespace InvoiceApp;

public class Address
{
    /* Properties */
    public string AddressLine { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";

    /* Constructor */
    public Address()
    {

    }

    /* Methods */
    public override string ToString()
    {
        return $"Address: {AddressLine}, {PostalCode}, {City}";
    }
}