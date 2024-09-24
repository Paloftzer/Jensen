namespace InvoiceApp;

// Parent Class
public class Company
{
    /* Properties */
    public string Name { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Reference { get; set; } = "";

    public Address Address { get; set; } = new Address();

    /* Methods */
    public virtual void Find()
    {
        Name = "Company #3";
        Address.AddressLine = "456 Elm St";
        Address.PostalCode = "987 65";
        Address.City = "Thattown";
        PhoneNumber = "555-555-5555";
        Reference = "Hjonh Dho";
    }
}