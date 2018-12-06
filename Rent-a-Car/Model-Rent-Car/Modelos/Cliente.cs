using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Rent_Car.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public string Direccion { get; set; }
        public bool Licencia { get; set; }
        public int Telefono { get; set; }
        public List<ProcesoRentado> ProcesoRentados { get; set; }
        public List<Inspeccion> Inspecciones { get; set; }
    }
}
