using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class ColeccionUsuario
    {
        public int ColeccionId { get; set; }
        public int UsuarioId { get; set; }
        public int CartaId { get; set; }
        public int Cantidad { get; set; }
    }
}
