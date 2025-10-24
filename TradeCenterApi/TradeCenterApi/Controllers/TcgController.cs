using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    /// <summary>
    /// Controlador para gestionar las operaciones relacionadas con los TCG (Trading Card Games).
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TcgController : Controller
    {
        private readonly ITcgQueries _tcgQueries;
        

        public TcgController(ITcgQueries tcgQueries)
        {
            _tcgQueries = tcgQueries ?? throw new ArgumentNullException(nameof(tcgQueries));
           
        }
        /// <summary>
        /// Metodo para listar todos los TCG.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var rs = await _tcgQueries.GetAll();
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
