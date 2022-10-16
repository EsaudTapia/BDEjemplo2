using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDEjemplo2.Models
{
    public class Direcciones
    {
        public int CodigoDireccion { get; set; }
        public string Calle { get; set; }
        public int IdPersona { get; set; }
        public Personas Personas { get; set; }
        public List<SubDireccion> SubDireccion { get; set; }
    }
}