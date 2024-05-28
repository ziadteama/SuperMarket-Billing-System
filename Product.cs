    using WinFormsApp1;

public class Product
{
    public string ProductName { get; set; }
    public string ProviderInfromation { get; set; }
    private int quantity;
    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value >= 0) quantity = value;
        }
    }
    private float unitprice;
    public float UnitPrice
    {
        get { return unitprice; }
        set
        {
            if (value >= 0) unitprice = value;
        }
    }
    private float sellprice;

    public float SellPrice
    {
        get { return sellprice; }
        set
        {
            if (value >= 0) sellprice = value;
        }
    }

    public Product(string productName, string providerInformation, int quantity, float unitPrice, float sellPrice)
    {
        this.ProductName = productName;
        this.ProviderInfromation = providerInformation;
        this.Quantity = quantity;
        this.UnitPrice = unitPrice;
        this.SellPrice = sellPrice;
    }

    public override string ToString()
    {
        return $"{ProductName} - Quantity: {Quantity} - Price: {SellPrice * Quantity:C}";
    }
    static public void UptadeQuantity(List<Product> products, Order order)
    {
        for (int i = 0; i < order.productname.Length; i++)
        {
            for (int j = 0; j < products.Count; j++)
            {
                if (order.productname[i] == products[j].ProductName)
                {
                    products[j].Quantity -= order.Quantity[i];
                    break;
                }
            }
        }
    }
    public static string  DisplayString(List<Product> P)
    {
        string X="";
       for(int i = 0;i < P.Count;i++)
        {
            X += P[i].ToString()+"\n";
        }
       return X ;
    }

}