using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con las colecciones de usuarios.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ColeccionUsuarioController : Controller
    {
        private readonly IColeccionUsuarioQueries _coleccionusuarioQueries;
        

        public ColeccionUsuarioController(IColeccionUsuarioQueries coleccionusuarioQueries)
        {
            _coleccionusuarioQueries = coleccionusuarioQueries ?? throw new ArgumentNullException(nameof(coleccionusuarioQueries));
    
        }
        /// <summary>
        /// Metodo para listar todas las colecciones de un usuario.
        /// </summary>
        /// <param name="UsuarioId"></param>
        /// <returns></returns>
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
