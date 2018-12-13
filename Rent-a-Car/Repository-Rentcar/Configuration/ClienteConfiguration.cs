using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model_Rent_Car.Modelos;

namespace Repository_Rentcar.Configuration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        
        public ClienteConfiguration()
        {
            ToTable("Cliente");
            Property(c => c.Nombre).IsRequired().HasMaxLength(100);
            Property(c => c.Cedula).IsRequired();
            Property(c => c.Direccion).IsRequired();
            Property(c => c.Licencia).IsRequired();
            Property(c => c.Telefono).IsRequired();
  
        }
    }
}
