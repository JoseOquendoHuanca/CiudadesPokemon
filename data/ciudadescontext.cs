using CiudadesPokemon.Models;
using Microsoft.EntityFrameworkCore;

namespace CiudadesPokemon.data
{
    public class ciudadescontext: DbContext
    {
        
 public DbSet<ciudades> ciu { get; set; }

        public ciudadescontext(DbContextOptions dco) : base(dco){


    }
}
}