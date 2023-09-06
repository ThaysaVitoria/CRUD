using Cinema.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    public class FilmeController : Controller
    {
        readonly private ApplicationDBContext _db;

        private FilmeController(ApplicationDBContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            IEnumerable<FilmeModel> filmes = _db.Filmes;
            return View(filmes);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
