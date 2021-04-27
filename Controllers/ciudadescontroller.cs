using System.Linq;
using CiudadesPokemon.data;
using CiudadesPokemon.Models;
using Microsoft.AspNetCore.Mvc;

namespace CiudadesPokemon.Controllers
{
    public class ciudadescontroller: Controller
    {
       
       private ciudadescontext _context;
       
      public ciudadescontroller(ciudadescontext context)
      {
             _context =context;
      }


        public IActionResult nuevo(){
          return   View();
        }

    [HttpPost]
    public IActionResult nuevo(ciudades p){

        if(ModelState.IsValid){
         //guardar el objeto en la base de datos 

         _context.Add(p);
         _context.SaveChanges();

         return RedirectToAction("lista");

     }
          return   View(p);
    }

 public IActionResult lista(){

            //seleciona la lista de la  base de datos y envia a la lista 

            var ciudad= _context.ciu.OrderBy(x=>x.nombre).ToList();
            return  View(ciudad );

        }

        
    }
}