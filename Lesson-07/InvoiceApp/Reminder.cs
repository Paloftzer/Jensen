namespace InvoiceApp;

public class Reminder : Invoice
{
    /* Properties */
    public decimal Interest { get; set; }
    public decimal Charge { get; set; }

    /* Constructors */
    public Reminder(int customerNumber) : base(customerNumber)
    {
        Interest = 0.25m;
    }

    /* Methods */
    public void CalculateReminderTotal()
    {
        Charge = TotalValue * Interest;
        TotalValue += Charge;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Charge: {Charge:N2}";
    }
}