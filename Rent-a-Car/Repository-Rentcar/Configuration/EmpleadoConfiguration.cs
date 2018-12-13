using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model_Rent_Car.Modelos;

namespace Repository_Rentcar.Configuration
{
    public class EmpleadoConfiguration :EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfiguration()
        {
            ToTable("Empleado");
            Property(c => c.Direccion).IsRequired();
            Property(c => c.Cedula).IsRequired();
            Property(c => c.Nombre).IsRequired();
            Property(c => c.Estado).IsRequired();

        }
    }
}
