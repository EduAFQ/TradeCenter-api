using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class Intercambio
    {
        [Key]
        public int IntercambioId { get; set; }
        public int UsuarioOferta { get; set; }
        public int UsuarioReceptor { get; set; }
        public required string EstadoIntercambio { get; set; }
        public DateTime FechaIntercambio { get; set; }
    }
}
