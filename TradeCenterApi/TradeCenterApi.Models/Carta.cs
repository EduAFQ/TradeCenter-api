using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class Carta
    {
        /// <summary>
        /// Identificador de la Carta
        /// </summary>
        [Key]
        public int CartaId { get; set; }
        /// <summary>
        /// Variable del Nombre de la Carta
        /// </summary>
        public required string Nombre { get; set; }
        /// <summary>
        /// Variable de la Edición de la Carta
        /// </summary>
        public required string Edicion { get; set; }
        /// <summary>
        /// Variable de la rareza de la Carta
        /// </summary>
        public int Rareza { get; set; }
        /// <summary>
        /// Variable del Estado de la Carta
        /// </summary>
        public required string EstadoCarta { get; set; }
        /// <summary>
        /// Variable de la imagen de la carta
        /// </summary>
        public string ImagenUrl { get; set; }
        /// <summary>
        /// Identificador TCG de la Carta
        /// </summary>
        public int TcgId { get; set; }
  
    }
}
