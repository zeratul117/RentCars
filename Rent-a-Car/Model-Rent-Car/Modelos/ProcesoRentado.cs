﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Rent_Car.Modelos
{
    public class ProcesoRentado
    {
        public int IdProceso { get; set; }
        public DateTime FechaRetiro { get; set; }
        public DateTime FechaEntrega { get; set; }
        public double Monto { get; set; }
        public string Nota { get; set; }
        [ForeignKey("Carro")]
        public int IdCarro { get; set; }
        public Carro Carros { get; set; }
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Clientes { get; set; }
        [ForeignKey("Empleado")]
        public int IdEmpleado { get; set; }
        public Empleado Empleados { get; set; }
    }
}
