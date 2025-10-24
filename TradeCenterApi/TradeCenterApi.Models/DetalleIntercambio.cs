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
        /// <summary>
        /// Identificador del Detalle del Intercambio
        /// </summary>
        [Key]
        public int DetalleIntercambioId { get; set; }
        /// <summary>
        /// Identificador del Intercambio al que pertenece el detalle
        /// </summary>
        public int IntercambioId { get; set; }
        /// <summary>
        /// Identificador de la Carta involucrada en el intercambio
        /// </summary>
        public int CartaId { get; set; }
        /// <summary>
        /// Variable de la Cantidad de Cartas en el Detalle del Intercambio
        /// </summary>
        public int Cantidad { get; set; }
    }
}
