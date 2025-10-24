using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con los usuarios.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioQueries _usuarioQueries;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository, IUsuarioQueries usuarioQueries)
        {
            _usuarioQueries = usuarioQueries ?? throw new ArgumentNullException(nameof(usuarioQueries));
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }
        /// <summary>
        /// Metodo para listar todos los usuarios.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var rs = await _usuarioQueries.GetAll();
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Metodo para Registrar un nuevo usuario.
        /// </summary>
        /// <param name="es"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Agregar(Usuario es)
        {
            try
            {
                var rs = await _usuarioRepository.Add(es);
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
