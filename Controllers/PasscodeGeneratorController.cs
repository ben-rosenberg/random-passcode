using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{

public class PasscodeGeneratorController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        int count;
        if (HttpContext.Session.GetInt32("Count") == null)
        {
            count = 1;
        }
        else
        {
            count = (int)HttpContext.Session.GetInt32("Count") + 1;
        }
        HttpContext.Session.SetInt32("Count", count);
        ViewBag.RandomPasscode = PasscodeGenerator.Generate();
        ViewBag.Count = HttpContext.Session.GetInt32("Count");
        return View("Index");
    }

    [HttpPost("/generate")]
    public IActionResult Generate()
    {
        return RedirectToAction("Index");
    }
}

}


/**

let session = {
    "Count": 1
}

*/