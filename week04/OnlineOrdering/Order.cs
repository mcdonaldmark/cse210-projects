using System;
class Order
{
    private Customer customer;
    private Product[] products;
    private int numProducts;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new Product[10];
        numProducts = 0;
    }

    public void AddProduct(Product product)
    {
        products[numProducts] = product;
        numProducts++;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0.00;
        foreach (Product product in products)
        {
            if (product != null)
            {
                totalPrice += product.GetPrice();
            }
        }
        if (customer.IsInUSA())
        {
            totalPrice += 5.00;
        }
        else
        {
            totalPrice += 35.00;
        }
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            if (product != null)
            {
                packingLabel += product.GetName() + " (" + product.GetId() + ")\n";
            }
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += customer.GetName() + "\n";
        shippingLabel += customer.GetAddress().completeAddress() + "\n";
        return shippingLabel;
    }
}