using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(0);
    }

    [HttpPost("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}
