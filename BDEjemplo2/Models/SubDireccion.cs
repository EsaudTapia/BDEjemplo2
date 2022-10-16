using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BDEjemplo2.Models
{
    public class SubDireccion
    {
        [Key]
        public int ID { get; set; }
        public string SubCalle { get; set; }

        public Direcciones Direcciones { get; set; }
    }
}