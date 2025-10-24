using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Implements;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con los intercambios.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class IntercambioController : Controller
    {
        private readonly IIntercambioRepository _intercambioRepository;

        public IntercambioController(IIntercambioRepository intercambioRepository)
        {
            
            _intercambioRepository = intercambioRepository ?? throw new ArgumentNullException(nameof(intercambioRepository));
        }
        /// <summary>
        /// Metodo para crear un nuevo intercambio.
        /// </summary>
        /// <param name="es"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Agregar(Intercambio es)
        {
            try
            {
                var rs = await _intercambioRepository.Add(es);
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Metodo para actualizar el estado de un intercambio.
        /// </summary>
        /// <param name="es"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Actualizar(Intercambio es)
        {
            try
            {
                var rs = await _intercambioRepository.Update(es);
                return Ok(rs);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
