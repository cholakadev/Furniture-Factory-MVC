namespace FurnitureFactory_MVC_Project.Controllers
{
    using FurnitureFactory_MVC_Project.Models;
    using FurnitureFactory_MVC_Project.Models.DataAccess;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrdersController : Controller
    {
        private readonly FurnitureFactoryDbContext _context;

        public OrdersController(FurnitureFactoryDbContext context)
        {
            _context = context;
        }

        public IActionResult Report()
        {
            return View(_context.OrderReports.ToList());
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var furnitureFactoryDbContext = _context.Sales.Include(o => o.Article).Include(o => o.Customer);
            return View(await furnitureFactoryDbContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Sales
                .Include(o => o.Article)
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["ArticleId"] = new SelectList(_context.Articles, "Id", "Name");
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CompanyName");
            return View();
        }

        // POST: Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OrderNumber,Date,CustomerId,ArticleId,Quantity,TotalPrice")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.Date = DateTime.Now;

                var article = _context.Articles.FirstOrDefault(a => a.Id == order.ArticleId);
                var sale = _context.Sales.FirstOrDefault(s => s.Id == order.Id);
                order.TotalPrice = order.Quantity * article.Price;

                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArticleId"] = new SelectList(_context.Articles, "Id", "Name", order.ArticleId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CompanyName", order.CustomerId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Sales.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["ArticleId"] = new SelectList(_context.Articles, "Id", "Name", order.ArticleId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "CompanyName", order.CustomerId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderNumber,Date,CustomerId,ArticleId,Quantity,TotalPrice")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArticleId"] = new SelectList(_context.Articles, "Id", "Description", order.ArticleId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Address", order.CustomerId);
            return View(order);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Sales
                .Include(o => o.Article)
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Sales.FindAsync(id);
            _context.Sales.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Sales.Any(e => e.Id == id);
        }
    }
}
