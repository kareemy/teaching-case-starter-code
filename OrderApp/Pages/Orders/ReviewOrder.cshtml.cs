using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderApp.Models;
using Microsoft.EntityFrameworkCore;
//using ShippingLibrary;
//using TaxLibrary;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.Pages_Orders;

public class ReviewOrderModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ILogger<ReviewOrderModel> _logger;

    public ReviewOrderModel(AppDbContext context, ILogger<ReviewOrderModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public Order Order { get; set; } = default!;
    
    [DataType(DataType.Currency)]
    public decimal ShippingCost {get; set;}
    
    [DataType(DataType.Currency)]
    public decimal TaxCost {get; set;}
    
    [DataType(DataType.Currency)]
    public decimal TotalCost {get; set;}

    public IActionResult OnGet(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var order = _context.Orders.Include(o => o.Products)!.ThenInclude(op => op.Product).FirstOrDefault(m => m.OrderID == id);

        if (order == null)
        {
            return NotFound();
        }
        else
        {
            Order = order;
            //ShippingCost = ShippingClass.CalculateShippingCost(Order.ZipCode);
            TotalCost = Order.Products!.Sum(p => p.Product.Price) + ShippingCost;
            //TaxCost = TotalCost * TaxClass.CalculateSalesTax(Order.ZipCode);
            TotalCost += TaxCost;
        }
        return Page();
    }
}
