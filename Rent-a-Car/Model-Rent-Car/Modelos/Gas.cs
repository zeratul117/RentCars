using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Rent_Car.Modelos
{
    public class Gas
    {
        public int IdGas { get; set; }
        public string Typo { get; set; }
        public List<Carro> Carros { get; set; }
    }
}
