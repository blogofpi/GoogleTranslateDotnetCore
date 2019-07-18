using GoogleTranslateDotnetCore.Utils;
using Microsoft.AspNetCore.Mvc;

namespace GoogleTranslateDotnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslatorController : ControllerBase
    {
        private readonly ITranslator _translator;
        public TranslatorController(ITranslator translator)
        {
            _translator = translator;
        }

        [HttpGet]
        [Route("Translate")]
        public ActionResult Translate(string text, string language)
        {
            var translatedText = _translator.TranslateText(text, language);
            return Ok(translatedText);
        }

        [HttpGet]
        [Route("TranslateHtml")]
        public ActionResult TranslateHtml(string html, string language)
        {
            var translatedText = _translator.TranslateHtml(html, language);
            return Ok(translatedText);
        }
    }
}