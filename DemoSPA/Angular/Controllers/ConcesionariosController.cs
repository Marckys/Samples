
using System.Web.Mvc;

namespace WebClient.Controllers
{
    public class ConcesionariosController : Controller
    {
        [OutputCacheAttribute(VaryByParam = "*", Duration = 0, NoStore = true)]
        public ActionResult List()
        {
            ViewBag.Title = "Vista Parcial Listado";
            return PartialView();
        }
        public ActionResult Detail()
        {
            ViewBag.Title = "Vista Parcial Detalle";
            return PartialView();
        }

        public ActionResult Edit()
        {
            ViewBag.Title = "Vista Parcial Edición";
            return PartialView();
        }
        public ActionResult Progress()
        {
            return PartialView();
        }

    }
}
