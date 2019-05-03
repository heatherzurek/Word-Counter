using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Create(string word, string phrase)
    {
      RepeatCounter newRepeatCounter = new RepeatCounter(word, phrase);
      return View("Index", newRepeatCounter);
    }

  }
}
