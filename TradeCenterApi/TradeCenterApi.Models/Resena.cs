using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class Resena
    {
        /// <summary>
        /// Identificador de la Reseña
        /// </summary>
        [Key]
        public int ResenaId { get; set; }
        /// <summary>
        /// Identificador del Usuario que realiza la Resena
        /// </summary>
        public int UsuarioId { get; set; }
        /// <summary>
        /// Variable de la Calificación de la Resena
        /// </summary>
        public int Calificacion { get; set; }
        /// <summary>
        /// Variable del comentario de la Resena
        /// </summary>
        public string Comentario { get; set; }
        /// <summary>
        /// Fecha de la Resena
        /// </summary>
        public DateTime FechaResena { get; set; }
    }
}
