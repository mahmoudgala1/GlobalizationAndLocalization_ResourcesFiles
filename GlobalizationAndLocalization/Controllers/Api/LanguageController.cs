using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace GlobalizationAndLocalization.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> _stringLocalizer;

        public LanguageController(IStringLocalizer<LanguageController> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_stringLocalizer["Welcome","Mahmoud"]);
        }
    }
}
