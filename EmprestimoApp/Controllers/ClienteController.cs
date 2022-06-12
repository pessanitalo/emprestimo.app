using EmprestimoApp.DataContext;
using EmprestimoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoApp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Context _context;

        public ClienteController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Clientes.ToList();
            return View(result);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (!ModelState.IsValid) return View(cliente);
                       
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
