using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioFinal.Models.DATA.DDL
{
    public class Clientes
    {
        public int Id { get; set; }

        public string nombre { get; set; }

        public ICollection<Vehiculo> vehiculos { get; set; }
    }
}
