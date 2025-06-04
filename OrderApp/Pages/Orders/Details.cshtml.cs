using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrderApp.Models;

namespace OrderApp.Pages_Orders
{
    public class DetailsModel : PageModel
    {
        private readonly OrderApp.Models.AppDbContext _context;

        public DetailsModel(OrderApp.Models.AppDbContext context)
        {
            _context = context;
        }

        public Order Order { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FirstOrDefaultAsync(m => m.OrderID == id);

            if (order is not null)
            {
                Order = order;

                return Page();
            }

            return NotFound();
        }
    }
}
