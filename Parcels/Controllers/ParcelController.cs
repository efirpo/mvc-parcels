using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]

    public ActionResult Index()
    {
      return View();
    }
  }
}