namespace InvoiceApp;

public class Sender
{
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Reference { get; set; } = "";
    public string ReferenceEmail { get; set; } = "";

    /* Constructor */
    public Sender()
    {
        LoadSenderInfo();
    }

    /* Methods */
    public override string ToString()
    {
        return $"Sender Name: {Name} - Address: {Address}, {PostalCode}, {City} - Phone Number: {PhoneNumber} - Reference: {Reference}, {ReferenceEmail}";
    }

    /* Private Methods */
    public void LoadSenderInfo()
    {
        Name = "Company #3";
        Address = "456 Elm St";
        PostalCode = "987 65";
        City = "Thattown";
        PhoneNumber = "555-555-5555";
        Reference = "Hjonh Dho";
        ReferenceEmail = "Hjonhdho@company#3.com";
    }
}