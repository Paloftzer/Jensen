using System.Security.Cryptography.X509Certificates;

namespace InvoiceApp;

public class Sender : Company
{
    /* Properties */
    public string ReferenceEmail { get; set; } = "";

    /* Constructor */
    public Sender()
    {
        Find();
    }

    /* Methods */
    public override string ToString()
    {
        return $"Sender Name: {Name} - Address: {Address} - Phone Number: {PhoneNumber} - Reference: {Reference}, {ReferenceEmail}";
    }

    /* Private Methods */
    // public void LoadSenderInfo()
    // {
    //     Name = "Company #3";
    //     Address.AddressLine = "456 Elm St";
    //     Address.PostalCode = "987 65";
    //     Address.City = "Thattown";
    //     PhoneNumber = "555-555-5555";
    //     Reference = "Hjonh Dho";
    //     ReferenceEmail = "Hjonhdho@company#3.com";
    // }
}