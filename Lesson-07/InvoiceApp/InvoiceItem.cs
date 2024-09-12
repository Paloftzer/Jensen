namespace InvoiceApp;

public class InvoiceItem
{
    /* Properties */

    /*  Product information initiation */
    public int NumberOfItems { get; set; }
    public decimal LineSum { get; set; }

    // Composition
    public Product Product { get; set; }

    /* Constructors */
    public InvoiceItem(Product product, int numberOfItems)
    {
        Product = product;
        NumberOfItems = numberOfItems;
        LineSum = Product.Price * NumberOfItems;
    }

    /* Methods */
    public override string ToString()
    {
        return $"Product name: {Product.Name} - Price: {Product.Price:N2} - Number of items: {NumberOfItems} - Line Sum: {LineSum:N2}";
    }
}