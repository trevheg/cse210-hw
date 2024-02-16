using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _domesticShippingCost;
    private int _intlShippingCost;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
        _domesticShippingCost = 5;
        _intlShippingCost = 35;
    }

    public void addProduct(string name, int productId, double price, int quantity)
    {
        _products.Add(new Product(name, productId, price, quantity));
    }
    public string GetShippingLabel()
    {
        Address address = _customer.GetAddress();
        string label = 
            $"Ship to: \n{_customer.GetName()}\n" +
            $"Address: \n" +
            address.GetAddress();
        return label;
    }
    public string GetPackingSlip()
    {
        string slip = "Order Contents:\n";
        foreach (Product product in _products)
        {
            slip += $"Product ID: {product.GetProductId()} {product.GetName()} x {product.GetQuantity()}\n";
        }
        return slip;
    }
    public double GetTotalPrice()
    {
        double price = 0;
        foreach (Product product in _products)
        {
            price += product.GetTotalPrice();
        }
        if (_customer.InUsa())
        {
            price += _domesticShippingCost;
        }
        else
        {
            price += _intlShippingCost;
        }
        return price;
    }
}