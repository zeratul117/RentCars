using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Model_Rent_Car.Modelos;

namespace Repository_Rentcar.Configuration
{
    public class CarroConfiguration : EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
        {
            ToTable("Carro");
          
            Property(c => c.Chasi).IsRequired();
            Property(c => c.Matricula).IsRequired();
            Property(c => c.NumMotor).IsRequired();
            Property(c => c.Estado).IsRequired();
            Property(c => c.IdColor).IsRequired();
            Property(c => c.IdGas).IsRequired();
            Property(c => c.IdModelo).IsRequired();
            Property(c => c.IdTipos).IsRequired();
        }
    }
}
