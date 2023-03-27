namespace CierreVuelo.Controllers
{
    using dbModel.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CierreVueloController : ControllerBase
    {
        private readonly PostgresContext _context;
        public CierreVueloController(PostgresContext context){
            _context=context;
        }
        [HttpGet]
        public  ActionResult Get()
        {
            var paises=_context.Paises.ToList();
            var paisStr="";
            for (int i = 0; i < paises.Count; i++)
            {
                paisStr += paises[i].Nombre+" con acronimo "+paises[i].Acronimo+" "+"/n";
            }
            
            return Ok("CIerre de vuelos cerrados en los paises: "+ paisStr);
        }
    }
}