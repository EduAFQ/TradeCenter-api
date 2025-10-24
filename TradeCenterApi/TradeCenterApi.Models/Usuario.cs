using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class Usuario
    {
        /// <summary>
        /// Identificador del Usuario
        /// </summary>
        [Key]
        public int UsuarioId { get; set; }
        /// <summary>
        /// Variable del Nombre del Usuario
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Variable del Email del Usuario
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Variable de la contrasena del Usuario
        /// </summary>
        public string Contrasena { get; set; }
        /// <summary>
        /// Variable de la fecha de registro del Usuario
        /// </summary>
        public DateTime FechaRegistro { get; set; }


    }
}
