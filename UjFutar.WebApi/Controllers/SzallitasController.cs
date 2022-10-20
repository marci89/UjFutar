using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using UjFutar.Models;

namespace UjFutar.WebApi.Controllers
{
	/// <summary>
	/// Szállítás menedzseléséhez készült Controller
	/// </summary>
	[Description("Szállítás menedzselése")]
	[Route("[controller]")]
	[ApiController]
	public class SzallitasController : Controller
	{

        /// <summary>
        /// Szállitasi adatok rögzítése
        /// </summary>
        [Description("Szállitasi adatok rögzítése")]
        [HttpPost]
        public IActionResult SzallitasiAdatokatRogzit([FromBody] SzallitasiAdatokatRogzitKeresModel request)
        {
			return Ok();
        }

    }
}
