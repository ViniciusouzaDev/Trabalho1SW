using Trabalho1SW.Context;
using Trabalho1SW.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Trabalho1SW.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly AppCont _appCont;

        public FornecedoresController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public ActionResult Index()
        {
            var allTasks = _appCont.Fornecedores.ToList();
            return View(allTasks);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Fornec = await _appCont.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);

            if (Fornec == null)
            {
                return BadRequest();
            }
            return View(Fornec);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Fornecedor Fornec)
        {
            if (ModelState.IsValid)
            {
                _appCont.Add(Fornec);
                await _appCont.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(Fornec);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Fornec = await _appCont.Fornecedores.FindAsync(id);
            if (Fornec == null)
            {
                return BadRequest();
            }
            return View(Fornec);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Fornecedor Fornec)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _appCont.Update(Fornec);
                await _appCont.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Fornec);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Fornec = await _appCont.Fornecedores
                .FirstOrDefaultAsync(x => x.Id == id);

            if (Fornec == null)
            {
                return NotFound();
            }
            return View(Fornec);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var Fornec = await _appCont.Fornecedores.FindAsync(id);
            _appCont.Fornecedores.Remove(Fornec);
            await _appCont.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }

}
