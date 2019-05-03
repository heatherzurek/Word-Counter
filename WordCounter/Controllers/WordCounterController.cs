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

    // [HttpPost("/wordcounter")]
    // public ActionResult Create(string findWord, string sentence)
    // {
    //   Word newWord = new Word(word, sentence);
    //   return View(newWord);
    // }

  }
}
