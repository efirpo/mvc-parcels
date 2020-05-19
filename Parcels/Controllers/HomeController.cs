using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}