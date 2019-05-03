using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    public ActionResult Index()
    {
      return View(0);
    }

    [HttpGet("/words/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/words")]
    public ActionResult Create(string word)
    {
      Word myWord = new Word(word);
      return RedirectToAction("Index");
    }

    [HttpPost("/words/delete")]
    public ActionResult DeleteAll()
    {
      Word.ClearAll();
      return View();
    }
  }

  }
