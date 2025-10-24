using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class Tcg
    {
        /// <summary>
        /// Identificador del Tcg
        /// </summary>
        [Key]
        public int TcgId { get; set; }
        /// <summary>
        /// Variable Nombre del Tcg
        /// </summary>
        public string NombreTcg { get; set; }
    }
}
