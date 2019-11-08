using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjercicioFinal.Models.DATA.DDL;

namespace EjercicioFinal.Models
{
    public class EjercicioFinalContext : DbContext
    {
        public EjercicioFinalContext (DbContextOptions<EjercicioFinalContext> options)
            : base(options)
        {
        }

        public DbSet<EjercicioFinal.Models.DATA.DDL.Clientes> Clientes { get; set; }

        public DbSet<EjercicioFinal.Models.DATA.DDL.TipoVehiculo> TipoVehiculo { get; set; }

        public DbSet<EjercicioFinal.Models.DATA.DDL.Vehiculo> Vehiculo { get; set; }
    }
}
