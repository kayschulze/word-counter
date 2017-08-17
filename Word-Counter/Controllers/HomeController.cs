using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/results")]
    public ActionResult Results()
    {
      string newWord = Request.Form["word"];
      string newPhrase = Request.Form["phrase"];
      RepeatCounter newCounter = new RepeatCounter(newWord, newPhrase);

      return View(newCounter);
    }
  }
}
