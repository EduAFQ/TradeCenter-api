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
        [Key]
        public int TcgId { get; set; }
        public string NombreTcg { get; set; }
    }
}
