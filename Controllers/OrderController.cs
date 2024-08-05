using CookieWebsite.Data;
using CookieWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookieWebsite.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Order> orders = _db.orders;
            return View(orders);
        }
        public IActionResult Create() 
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order)
        {
            _db.orders.Add(order);
            _db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}
