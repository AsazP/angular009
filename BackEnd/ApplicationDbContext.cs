using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd
{
    public class ApplicationDbContext:DbContext
    {

        //el constructor va a recibir como parametro la cadena de coneccion
        // utilizando (inyeccion de dependencias)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TarjetaCredito> TarjetaCredito { set; get; }

    }
}
