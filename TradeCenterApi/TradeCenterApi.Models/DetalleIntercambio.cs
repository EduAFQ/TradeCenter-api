using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class DetalleIntercambio
    {
        [Key]
        public int DetalleIntercambioId { get; set; }
        public int IntercambioId { get; set; }
        public int CartaId { get; set; }
        public int Cantidad { get; set; }
    }
}
