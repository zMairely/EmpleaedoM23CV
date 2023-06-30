﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado23AM.Entities
{
    public class Empleado
    {
        [Key]
        public int PKempleado { get; set; } 
        public string Nombre { get; set; }  
        public string Apellido { get; set; }    
        public DateTime FechaRegistro { get; set; }
        public string Correo { get; set; }  

    }
}
