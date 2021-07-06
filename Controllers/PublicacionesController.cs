
using Microsoft.AspNetCore.Mvc;
using CSeC.web.Models;
using System.Linq;
using CSeC.web.Data;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CSeC.web.Controllers
{   
    [Authorize]
    public class PublicacionesController : Controller
    {   
        
        private readonly ApplicationDbContext _context;

        public PublicacionesController(ApplicationDbContext context)
        {   
            _context = context;

           
        }
        public IActionResult Publicaciones()
        {
            return View(_context.Publicaciones.ToList());  
        }

        [HttpPost]
        public IActionResult Guardar(string titulo, int precio)
        {   
            Publicaciones nuevo = new Publicaciones();
            nuevo.Titulo = titulo;
            // nuevo.Categoria = categoria;
            nuevo.Precio = precio;

            _context.Publicaciones.Add(nuevo);
            _context.SaveChanges();

            return RedirectToAction("Publicaciones");
            
        }
        public IActionResult Editar(int id)
        {
            Publicaciones editar = _context.Publicaciones.FirstOrDefault(i => i.ID ==id);

            return View(editar);
        } 
        public IActionResult Actualizar(int id, string titulo, int precio, string descripcion)
        {
            Publicaciones editar = _context.Publicaciones.FirstOrDefault(i => i.ID ==id);
            editar.Descripcion = descripcion;
            editar.Titulo = titulo;
            editar.Precio = precio;
            // editar.Categoria = categoria;
            _context.SaveChanges();

            return RedirectToAction("Publicaciones");
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
        public IActionResult Create()
        {

            List<Categoria> categoriasList = _context.Categorias.ToList();

            ViewBag.CategoriasList = new SelectList(categoriasList, "ID", "Descripcion");

            return View();
        }
    } 


}