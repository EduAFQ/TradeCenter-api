using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class Resena
    {
        public int ResenaId { get; set; }
        public int UsuarioId { get; set; }
        public int Calificacion { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaResena { get; set; }
    }
}
