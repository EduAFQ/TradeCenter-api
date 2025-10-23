using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Implements;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntercambioController : Controller
    {
        private readonly IIntercambioRepository _intercambioRepository;

        public IntercambioController(IIntercambioRepository intercambioRepository)
        {
            
            _intercambioRepository = intercambioRepository ?? throw new ArgumentNullException(nameof(intercambioRepository));
        }
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
