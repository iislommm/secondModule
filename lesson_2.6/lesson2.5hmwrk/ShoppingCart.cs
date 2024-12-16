using System.Security.Authentication.ExtendedProtection;

namespace lesson_2._6.lesson2._5hmwrk;

public class ShoppingCart
{
    private List<Products> _products;

    public ShoppingCart()
    {
        _products = new List<Products>();
    }

    public Products AddProducts (Products product)
    {
        _products.Add(product);
        return product;
    }
    public double GetTotalPrice ()
    {
        var totalPrice = 0d;

        foreach (var product in _products)
        {
            totalPrice += product.Price + product.Stock;
        }
        return totalPrice;
    }







}

