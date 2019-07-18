using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GoogleTranslateDotnetCore.Models;
using GoogleTranslateDotnetCore.Utils;

namespace GoogleTranslateDotnetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITranslator _translator;
        public HomeController(ITranslator translator)
        {
            _translator = translator;
        }
        public IActionResult Index()
        {
            var text = "Translate using Google";
            var translatedText = _translator.TranslateText(text, "ta");
            return View("Index", translatedText);
        }

        public IActionResult Translate()
        {
            return View();
        }
        public IActionResult TranslateHtml()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
