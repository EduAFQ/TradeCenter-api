﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCenterApi.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaRegistro { get; set; }


    }
}
