using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Rent_Car.Modelos
{
    public class Modelo
    {
        public int IdModelo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public int Idmarca { get; set; }
        public Marca Marcas { get; set; }
        public List<Carro> Carros { get; set; }

    }
}
