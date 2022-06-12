using EmprestimoApp.DataContext;
using EmprestimoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoApp.Controllers
{
    public class EmprestimoController : Controller
    {
        private readonly Context _context;

        public EmprestimoController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Emprestimos.ToList();
            return View(result);
        }

        public IActionResult Create(int id)
        {
            var emprestimo = new Emprestimo();
            emprestimo.ClienteId = id;

            return View(emprestimo);
        }

        [HttpPost]
        public IActionResult Create(Emprestimo emprestimo)
        {

            if (!ModelState.IsValid) return View(emprestimo);
            emprestimo.Id = 0;


            var calc = emprestimo.ValorTotal(emprestimo.ValorEmprestimo);
            emprestimo.valorTotal = calc;

            var parcelas = emprestimo.ValorParcela(calc, emprestimo.QuantidadeParcelas);
            emprestimo.ValorDaParcela = parcelas;

           var saldoatual = emprestimo.Cliente.SaldoAtual;

            _context.Emprestimos.Add(emprestimo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
