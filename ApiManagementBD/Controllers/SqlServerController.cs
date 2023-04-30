using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiManagementBD.Controllers
{
    public class SqlServerController : Controller
    {
        // GET: SqlServerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SqlServerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SqlServerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SqlServerController/Create
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

        // GET: SqlServerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SqlServerController/Edit/5
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

        // GET: SqlServerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SqlServerController/Delete/5
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
