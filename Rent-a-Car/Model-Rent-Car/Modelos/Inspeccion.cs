using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Rent_Car.Modelos
{
    public  class Inspeccion
    {
        public int IdInspeccion { get; set; }
        public string Descripcion { get; set; }
        public string CantGasolina { get; set; }
        public bool SpareTire { get; set; }
        public bool SpareCat { get; set; }
        public DateTime Fecha { get; set; }
 
        public int IdCarro { get; set; }
        public Carro Carros { get; set; }
   
        public int IdCliente { get; set; }
        public Cliente Clientes { get; set; }

        public int IdEmpleado { get; set; }
        public Empleado Empleados { get; set; }
    }
}
