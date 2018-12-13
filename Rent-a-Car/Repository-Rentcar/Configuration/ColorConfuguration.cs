using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model_Rent_Car.Modelos;

namespace Repository_Rentcar.Configuration
{
    public class ColorConfuguration : EntityTypeConfiguration<Color>
    {
        public ColorConfuguration()
        {
            ToTable("Color");
            Property(c => c.Descripcion).IsRequired();
        }
    }
}
