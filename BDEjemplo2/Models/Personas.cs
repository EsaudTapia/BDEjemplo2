using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDEjemplo2.Models
{
    public class Personas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Nacimiento { get; set; }   
        public int Edad { get; set; }
        public int Sexo { get; set; }
        public List<Direcciones> Direcciones { get; set; }
    }
}