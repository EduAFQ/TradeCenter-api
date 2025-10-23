using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class Carta
    {
        public int CartaId { get; set; }
        public required string Nombre { get; set; }
        public required string Edicion { get; set; }
        public int Rareza { get; set; }
        public required string EstadoCarta { get; set; }
        public string ImagenUrl { get; set; }
        public int TcgId { get; set; }
  
    }
}
