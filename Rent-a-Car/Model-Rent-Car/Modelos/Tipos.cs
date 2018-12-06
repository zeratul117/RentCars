using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Rent_Car.Modelos
{
    public class Tipos
    {
        public int IdTipos { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public List<Carro> Carros { get; set; }
    }
}
