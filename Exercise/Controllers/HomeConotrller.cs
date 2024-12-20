using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Store()
    {
        var products = JsonSerializer.Deserialize<List<Product>>(System.IO.File.ReadAllText("products.json"));
        return View(products);
    }

    public IActionResult MyOrders()
    {
        var orders = JsonSerializer.Deserialize<List<Order>>(System.IO.File.ReadAllText("orders.json"));
        if (orders == null)
        {
            orders = new List<Order>();
        }
        var orderSummaries = orders.Select(o => new
        {
            OrderId = o.Id,
            NetPrice = o.Items.Sum(i => i.NetCost)
        }).ToList();
        return View(orderSummaries);
    }
}