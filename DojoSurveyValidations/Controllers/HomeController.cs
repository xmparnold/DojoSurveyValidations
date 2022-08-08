using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidations.Models;

namespace DojoSurveyValidations.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/survey")]
    public IActionResult Survey() {
        return View("Survey");

    }

    [HttpGet("/success")]
    public IActionResult Success() {
        string? name = HttpContext.Session.GetString("name");

        if (name != null) {
            return View("Sucess");
        }
        else {
            return Survey();
        }
    }

    [HttpPost("/postsurvey")]
    public IActionResult PostSurvey(Survey newSurvey) {
        if (ModelState.IsValid) {
            HttpContext.Session.SetString("name", newSurvey.Name);
            HttpContext.Session.SetString("location", newSurvey.Location);
            HttpContext.Session.SetString("favoritelanguage", newSurvey.FavoriteLanguage);
            if (newSurvey.Comment != null) {
                HttpContext.Session.SetString("comment", newSurvey.Comment);
            }
            
            return View("Success");
            
        }

        return Survey();

    }

    public IActionResult Privacy()
    {
        return View();
    }


}
