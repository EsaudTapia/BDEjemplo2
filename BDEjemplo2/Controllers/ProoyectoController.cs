using BDEjemplo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.SqlClient;

namespace BDEjemplo2.Controllers
{
    public class ProoyectoController : Controller
    {
        // GET: Prooyecto
        public ProyectoDbContext db = new ProyectoDbContext();
        public ActionResult Index()
        {
            var persona1 = db.Persona.Include(p => p.Direcciones).ToList();
            //var persona1 = db.Persona.Include(p => p.Direcciones).ToString();
            var perDir = persona1[0].Direcciones[0];
            var tem = db.Persona.Include(x => x.Direcciones.Select(y => y.SubDireccion)).FirstOrDefault();
            var tem1 = db.Persona.ToString();
            var sub = tem.Direcciones[0].SubDireccion[0].SubCalle;
            var datos = db.Persona.SqlQuery("Select * from dbo.Personas where Id=@Id",new SqlParameter("@Id",1)).ToList();
            return View();
        }

    }
}