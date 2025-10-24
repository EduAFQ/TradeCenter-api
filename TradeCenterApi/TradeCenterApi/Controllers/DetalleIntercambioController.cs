using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Repository.Implements;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con los detalles de los intercambios.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleIntercambioController : Controller
    {
        private readonly IDetalleIntercambioQueries _detalleintercambioQueries;


        public DetalleIntercambioController(IDetalleIntercambioQueries detalleintercambioQueries)
        {
            _detalleintercambioQueries = detalleintercambioQueries ?? throw new ArgumentNullException(nameof(detalleintercambioQueries));

        }

        /// <summary>
        /// Metodo para listar todos los detalles de un intercambio por su ID.
        /// </summary>
        /// <param name="IntercambioId"></param>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> Listar(int IntercambioId)
        {
            try
            {
                var rs = await _detalleintercambioQueries.GetDetalleByIntercambioId(IntercambioId);
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
