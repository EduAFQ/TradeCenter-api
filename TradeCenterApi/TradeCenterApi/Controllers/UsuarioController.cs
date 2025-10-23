using Microsoft.AspNetCore.Mvc;
using TradeCenterApi.Models;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioQueries _usuarioQueries;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository, IUsuarioQueries usuarioQueries)
        {
            _usuarioQueries = usuarioQueries ?? throw new ArgumentNullException(nameof(usuarioQueries));
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var rs = await _usuarioQueries.GetUsuario();
                return Ok(rs);
            }
            catch (Exception)
            {

                throw;
            }
        }

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
