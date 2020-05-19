using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index(int length, int width, int height, int weight)
    {
      Parcel parcel = new Parcel();
      Parcel.GetDimensions(length, width, height, weight);
      return View(parcel);
    }
  }
}