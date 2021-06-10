using MagentaSportwear.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagentaSportwear.Controllers
{
    public class RegistrosController : Controller
    {
        [HttpPost]
        public JsonResult AddArticulo(string nombre, int precio)
        {

            if (nombre != null)
            {

                var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseMySql("Server=magentadatabase.c9ua8oprngoj.sa-east-1.rds.amazonaws.com;Database=magentasportwear;User=root;Password=11251073", new MySqlServerVersion(new Version(8, 0, 25)))
                .Options;

                var context = new ApplicationDbContext(contextOptions);

                using var db = context;
                var Articulo = new ApplicationDbContext.Articulo
                {
                    Nombre = nombre,
                    Precio = precio
                };

                db.AspNetArticulos.Add(Articulo);
                db.SaveChanges();
            }
            else
            {
                return Json(Response.StatusCode);
            }
            
            return Json(nombre);
        }

        [HttpPost]
        public async Task<JsonResult> GetArticulos()
        {

            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseMySql("Server=magentadatabase.c9ua8oprngoj.sa-east-1.rds.amazonaws.com;Database=magentasportwear;User=root;Password=11251073", new MySqlServerVersion(new Version(8, 0, 25)))
            .Options;

            var context = new ApplicationDbContext(contextOptions);

            using var db = context;
            var Articulos = await context.AspNetArticulos.ToListAsync();
            return Json(Articulos);

        }

        [HttpPost]
        public JsonResult DeleteArticulo(int id)
        {
            if (id.ToString() != null)
            {

                var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseMySql("Server=magentadatabase.c9ua8oprngoj.sa-east-1.rds.amazonaws.com;Database=magentasportwear;User=root;Password=11251073", new MySqlServerVersion(new Version(8, 0, 25)))
                .Options;

                var context = new ApplicationDbContext(contextOptions);

                using var db = context;
                var Articulo = new ApplicationDbContext.Articulo
                {
                    Id = id
                };

                db.AspNetArticulos.Remove(Articulo);
                db.SaveChanges();
            }
            else
            {
                return Json(Response.StatusCode);
            }

            return Json("Articulo eliminado");
        }
    }
}
