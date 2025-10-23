using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    public class CartaController : Controller
    {
        private readonly ICartaQueries _cartaQueries;
        private readonly ICartaRepository _cartaRepository;

        public CartaController(ICartaRepository cartaRepository, ICartaQueries cartaQueries)
        {
            _cartaQueries = cartaQueries ?? throw new ArgumentNullException(nameof(cartaQueries));
            _cartaRepository = cartaRepository ?? throw new ArgumentNullException(nameof(cartaRepository));
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var rs = await _cartaQueries.GetAll();
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(Carta es)
        {
            try
            {
                var rs = await _cartaRepository.Add(es);
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
