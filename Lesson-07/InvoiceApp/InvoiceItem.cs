namespace InvoiceApp;

public class InvoiceItem
{
    /* Properties */

    /*  Product information initiation */
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public decimal LineSum { get; set; }

    /* Constructor */
    public InvoiceItem()
    {
        ProductName = "";
    }

    /* Methods */
    public void AddProduct(int productId, string productName, decimal price, int amount)
    {
        // Move the parameters to the properties
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Amount = amount;
        LineSum = Price * Amount;
    }

    public override string ToString()
    {
        return $"Product name: {ProductName} - Price: {Price:N2} - Amount: {Amount} - Line Sum: {LineSum:N2}";
    }
}
