using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Rent_Car.Modelos
{
    public class Color
    {
        public int IdColor { get; set; }
        public string Descripcion { get; set; }
        public List<Carro> Carros { get; set; }
    }
}
