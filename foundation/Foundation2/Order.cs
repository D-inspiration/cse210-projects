using System;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (Product product in products)
        {
            total += product.TotalCost();
        }
        if (customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += product.Name + " (" + product.ProductId + ")\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return customer.Address.ToString();
    }
}
