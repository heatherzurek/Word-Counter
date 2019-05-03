// using Microsoft.AspNetCore.Mvc;
// using WordCounter.Models;
//
// namespace WordCounter.Controllers
// {
//   public class HomeController : Controller
//   {
//     [HttpGet("/")]
//     public ActionResult Index()
//     {
//       return View(0);
//     }
//
//     [HttpPost("/wordcounter/new")]
//     public ActionResult New()
//     {
//       return View();
//     }
//
//   }
// }

using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;


namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(0);
    }

    // [HttpGet("/wordcounter/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }
    //
    // [HttpPost("/wordcounter")]
    // public ActionResult Create(string makemodel, int price, int miles)
    // {
    //   Word findWord = new Word(_findWord);
    //   return RedirectToAction("Index");
    // }


  }
}
