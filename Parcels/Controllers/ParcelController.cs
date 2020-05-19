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
    public ActionResult Index(string length, string width, string height, string weight)
    {
      if (length == null || width == null || height == null || weight == null)
      {
        return View("../Home/Error");
      }
      else
      {
        Parcel parcel = new Parcel();
        Parcel.GetDimensions(length, width, height, weight);
        return View(parcel);
      }
    }
  }
}