namespace InvoiceApp;

public class Product
{
    /* Properties */
    public int ItemNumber { get; private set; }
    public string Name { get; private set; } = "";
    public decimal Price { get; private set; }

    /* Constructors */
    public Product()
    {

    }

    public Product(int itemNumber)
    {
        ItemNumber = itemNumber;
        FindProduct();
    }

    public void AddNewProduct(int itemNumber, string name, decimal price)
    {
        ItemNumber = itemNumber;
        Name = name;
        Price = price;
    }

    /* Methods */
    public override string ToString()
    {
        return $"Product Id: {ItemNumber} - Product Name: {Name} - Product Price: {Price}";
    }

    /* Private Methods */
    private void FindProduct()
    {
        if (ItemNumber == 1)
        {
            Name = "F/A-18C Hornet";
            Price = 33500000.00m;
        }
        else if (ItemNumber == 2)
        {
            Name = "F-22 Raptor";
            Price = 190000000.00m;
        }
        else
        {
            throw new ArgumentException($"Could not find product with Id: {ItemNumber}");
        }
    }
}