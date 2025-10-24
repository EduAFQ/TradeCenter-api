using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class ColeccionUsuario
    {
        /// <summary>
        /// Identificador de la Colección del Usuario
        /// </summary>
        [Key]
        public int ColeccionId { get; set; }
        /// <summary>
        /// Identificador del Usuario propietario de la colección
        /// </summary>
        public int UsuarioId { get; set; }
        /// <summary>
        /// Identificador de la Carta en la colección
        /// </summary>
        public int CartaId { get; set; }
        /// <summary>
        /// Variable de la Cantidad de Cartas en la Colección del Usuario
        /// </summary>
        public int Cantidad { get; set; }
    }
}
