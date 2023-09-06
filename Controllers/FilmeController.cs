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
        [HttpPost]
        public IActionResult Cadastrar(FilmeModel filme)
        {
            if (ModelState.IsValid)
            {
                _db.Filmes.Add(filme);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FilmeModel filme = _db.Filmes.FirstOrDefault(x => x.Id == id);

            if (filme == null)
            {
                return NotFound();
            }

            return View(filme);
        }

        [HttpPost]
        public IActionResult Editar(FilmeModel filme)
        {
            if (ModelState.IsValid)
            {
                _db.Filmes.Update(filme);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(filme);
        }
        [HttpGet]

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FilmeModel filme = _db.Filmes.FirstOrDefault(x => x.Id == id);

            if (filme == null)
            {
                return NotFound();
            }
            return View(filme);
        }
        [HttpPost]
        public IActionResult Excluir(FilmeModel filme)
        {
            if (filme == null)
            {
                return NotFound();
            }
            _db.Filmes.Remove(filme);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}