using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColeccionUsuarioController : Controller
    {
        private readonly IColeccionUsuarioQueries _coleccionusuarioQueries;
        

        public ColeccionUsuarioController(IColeccionUsuarioQueries coleccionusuarioQueries)
        {
            _coleccionusuarioQueries = coleccionusuarioQueries ?? throw new ArgumentNullException(nameof(coleccionusuarioQueries));
    
        }

        [HttpGet]
        public async Task<IActionResult> Listar(int UsuarioId)
        {
            try
            {
                var rs = await _coleccionusuarioQueries.GetColeccionByUsuarioId(UsuarioId);
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
