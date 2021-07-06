
using Microsoft.AspNetCore.Mvc;
using CSeC.web.Models;
using System.Linq;
using CSeC.web.Data;
using Microsoft.AspNetCore.Authorization;

namespace CSeC.web.Controllers
{   
    [Authorize]
    public class CategoriasController : Controller
    {   
        
        private ApplicationDbContext context;

        public CategoriasController(ApplicationDbContext context)
        {   
            this.context = context;

           
        }
        public IActionResult index()
        {
            return View(context.Categorias.ToList());  
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(string descripcion, string estado)
        {   
            Categoria nuevo = new Categoria();
            nuevo.Descripcion = descripcion;
            nuevo.Estado = estado;

            context.Categorias.Add(nuevo);
            context.SaveChanges();

            return RedirectToAction("index");
            
        }
        public IActionResult Editar(int id)
        {
            Categoria editar = context.Categorias.FirstOrDefault(i => i.ID ==id);

            return View(editar);
        } 
        public IActionResult Actualizar(int id, string descripcion, string estado)
        {
            Categoria editar = context.Categorias.FirstOrDefault(i => i.ID ==id);
            editar.Descripcion = descripcion;
            editar.Estado = estado;
            context.SaveChanges();

            return RedirectToAction("index");
        }
        //   public IActionResult Detalle(string categoria, string estado, int repe)
        // {
        //     ViewData["dataCategorias"] = categoria;
        //     ViewData["dataEstado"] = estado;
        //     ViewBag.Categoria = categoria;
        //     ViewBag.Estado = estado;
        //     ViewBag.Repeticiones = repe;
        //     return View();
        // }

    } 


}