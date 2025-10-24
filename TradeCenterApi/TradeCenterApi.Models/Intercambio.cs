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
        /// <summary>
        /// Identificador del Intercambio
        /// </summary>
        [Key]
        public int IntercambioId { get; set; }
        /// <summary>
        /// Identificador del Usuario que ofrece el intercambio
        /// </summary>
        public int UsuarioOferta { get; set; }
        /// <summary>
        /// Identificador del Usuario que recibe el intercambio
        /// </summary>
        public int UsuarioReceptor { get; set; }
        /// <summary>
        /// Variable del Estado del Intercambio
        /// </summary>
        public required string EstadoIntercambio { get; set; }
        /// <summary>
        /// Fecha del Intercambio
        /// </summary>
        public DateTime FechaIntercambio { get; set; }
    }
}
