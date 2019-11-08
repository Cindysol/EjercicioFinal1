using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioFinal.Models.DATA.DDL
{
    public class Vehiculo
    {
        public int Id { get; set; }

        public string placa { get; set;}

        public string nombre { get; set; }



        //de uno a muchos
        [ForeignKey("TipoVehiculo")]
        public int TipoVehiculoId { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }

        [ForeignKey("Clientes")]
        public int ClientesId { get; set; }
        public Clientes Clientes { get; set; }
    }
}
