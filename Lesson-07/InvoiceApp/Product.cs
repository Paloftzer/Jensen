namespace InvoiceApp;

public class Product
{
    /* Properties */
    public int ItemNumber { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    /* Constructor */
    public Product()
    {
        Name = "";
    }

    /* Methods */
    public override string ToString()
    {
        return $"Product Id: {ItemNumber} - Product Name: {Name} - Product Price: {Price}";
    }
}
