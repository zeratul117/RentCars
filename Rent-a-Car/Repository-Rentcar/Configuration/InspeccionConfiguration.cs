using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model_Rent_Car.Modelos;

namespace Repository_Rentcar.Configuration
{
    public class InspeccionConfiguration : EntityTypeConfiguration<Inspeccion>
    {
        public InspeccionConfiguration()
        {
            ToTable("Inseccion");
            Property(c => c.Descripcion).IsRequired().HasMaxLength(100);
            Property(c => c.CantGasolina).IsRequired();
            Property(c => c.SpareTire).IsRequired();
            Property(c => c.SpareCat).IsRequired();
            Property(c => c.Fecha).IsRequired();
        }
    }
}
