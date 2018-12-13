using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model_Rent_Car.Modelos;

namespace Repository_Rentcar.Configuration
{
    public class ModeloConfiguration : EntityTypeConfiguration<Modelo>
    {
        public ModeloConfiguration()
        {
            ToTable("Modelo");
            Property(c => c.Descripcion).IsRequired().HasMaxLength(100);
            Property(c => c.Estado).IsRequired();
            Property(c => c.Idmarca).IsRequired();
        }
    }
}
