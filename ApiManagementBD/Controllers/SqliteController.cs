using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiManagementBD.Controllers
{
    public class SqliteController : Controller
    {
        // GET: SqliteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SqliteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SqliteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SqliteController/Create
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

        // GET: SqliteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SqliteController/Edit/5
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

        // GET: SqliteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SqliteController/Delete/5
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
