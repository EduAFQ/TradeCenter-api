using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con las reseñas.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ResenaController : Controller
    {
        private readonly IResenaQueries _resenaQueries;
        private readonly IResenaRepository _resenaRepository;

        public ResenaController(IResenaRepository resenaRepository, IResenaQueries resenaQueries)
        {
            _resenaQueries = resenaQueries ?? throw new ArgumentNullException(nameof(resenaQueries));
            _resenaRepository = resenaRepository ?? throw new ArgumentNullException(nameof(resenaRepository));
        }
        /// <summary>
        /// Metodo para listar todas las reseñas de un usuario.
        /// </summary>
        /// <param name="UsuarioId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Listar(int UsuarioId)
        {
            try
            {
                var rs = await _resenaQueries.GetResenasByUsuarioId(UsuarioId);
                return Ok(rs);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Metodo para crear una nueva reseña.
        /// </summary>
        /// <param name="es"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Agregar(Resena es)
        {
            try
            {
                var rs = await _resenaRepository.Add(es);
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
