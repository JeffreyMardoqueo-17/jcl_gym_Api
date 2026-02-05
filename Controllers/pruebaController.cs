using System;
using Microsoft.AspNetCore.Mvc;

namespace jcl_gym_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PruebaController : ControllerBase
    {
        // GET: api/Prueba
        [HttpGet]
        public IActionResult Get()
        {
            // Configurar zona horaria de El Salvador
            var timeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            var fechaElSalvador = TimeZoneInfo.ConvertTime(DateTime.UtcNow, timeZone);
            return Ok(new
            {
                Mensaje = "Esto es una prueba 1",
                FechaElSalvador = fechaElSalvador.ToString("dd-MM-yyyy") 
            });
        }
    }
}
