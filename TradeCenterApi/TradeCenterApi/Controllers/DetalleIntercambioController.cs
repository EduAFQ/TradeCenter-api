using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Repository.Implements;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleIntercambioController : Controller
    {
        private readonly IDetalleIntercambioQueries _detalleintercambioQueries;


        public DetalleIntercambioController(IDetalleIntercambioQueries detalleintercambioQueries)
        {
            _detalleintercambioQueries = detalleintercambioQueries ?? throw new ArgumentNullException(nameof(detalleintercambioQueries));

        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var rs = await _detalleintercambioQueries.GetDetalleByIntercambioId();
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
