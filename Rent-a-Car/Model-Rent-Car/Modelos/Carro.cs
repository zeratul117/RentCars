using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Rent_Car.Modelos
{
    public class Carro
    {
        public int IdCarro { get; set; }
        public string Chasi { get; set; }
        public string Matricula { get; set; }
        public string NumMotor { get; set; }
        public bool Estado { get; set; }
        public List<ProcesoRentado> ProcesoRentados { get; set; }
        public List<Inspeccion> Inspecciones { get; set; }
        
        public int IdColor { get; set; }
        public Color Colores { get; set; }
       
        public int IdTipos { get; set; }
        public Tipos Tipos { get; set; }

        public int IdGas { get; set; }
        public Gas Gases { get; set; }
       
        public int IdModelo { get; set; }
        public Modelo Modelos { get; set; }
    }
}
