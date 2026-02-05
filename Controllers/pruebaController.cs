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
            // esto solo muestr la fecha de ek salvador
            var timeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            var fechaElSalvador = TimeZoneInfo.ConvertTime(DateTime.UtcNow, timeZone);
            return Ok(new
            {
                Mensaje = "Esto es una prueba",
                FechaElSalvador = fechaElSalvador.ToString("dd-MM-yyyy") 
            });
        }
    }
}
