using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SudokuSolverApi.Controllers
{
    public class HomeggController : Controller
    {
        // GET: HomeggController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeggController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeggController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeggController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeggController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeggController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeggController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeggController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
