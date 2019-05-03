using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    // [HttpGet("/wordcounter/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }
    //
    // [HttpPost("/pets")]
    // public ActionResult Create(string word)
    // {
    //   RepeatCounter myWord = new RepeatCounter(word);
    //   return RedirectToAction("Index");
    // }

    // [HttpPost("/wordcounter")]
    // public ActionResult Create(string findWord, string sentence)
    // {
    //   Word newWord = new Word(word, sentence);
    //   return View(newWord);
    // }

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
