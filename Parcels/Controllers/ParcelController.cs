using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    // [HttpGet("/parcels")]
    // public ActionResult Index()
    // {
    //   return View();
    // }


    [HttpPost("/parcels")]
    public ActionResult Index(int length, int width, int height, int weight)
    {
      Parcel parcel = new Parcel();
      Parcel.GetDimensions(length, width, height, weight);
      return View(parcel);
    }
  }
}