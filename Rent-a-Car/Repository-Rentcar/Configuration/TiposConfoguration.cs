using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model_Rent_Car.Modelos;

namespace Repository_Rentcar.Configuration
{
    public class TiposConfoguration : EntityTypeConfiguration<Tipos>
    {
        public TiposConfoguration()
        {
            ToTable("Tipos");
            Property(c => c.Descripcion).IsRequired();
            Property(c => c.Estado).IsRequired();
        }
    }
}
