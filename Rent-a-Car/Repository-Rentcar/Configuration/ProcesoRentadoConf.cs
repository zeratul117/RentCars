using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model_Rent_Car.Modelos;

namespace Repository_Rentcar.Configuration
{
    public class ProcesoRentadoConf : EntityTypeConfiguration<ProcesoRentado>
    {
        public ProcesoRentadoConf()
        {
            ToTable("ProcesoRentado");
            Property(c => c.FechaEntrega).IsRequired();
            Property(c => c.FechaRetiro).IsRequired();
            Property(c => c.Monto).IsRequired();
            Property(c => c.Nota).IsRequired();
            Property(c => c.IdCarro).IsRequired();
            Property(c => c.IdCliente).IsRequired();
            Property(c => c.IdEmpleado).IsRequired();


        }
    }
}
