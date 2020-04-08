using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTC.Model;

namespace MTC.Persistence.Database.Config
{
    public class PersonalConfig
    {
        public PersonalConfig(EntityTypeBuilder<Personal> entityBuilder)
        {
            entityBuilder.Property(x => x.Nombres).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Apellido_Paterno).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Apellido_Materno).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Direccion).HasMaxLength(200);
            entityBuilder.Property(x => x.Perfil).HasMaxLength(300);
            entityBuilder.Property(x => x.Experiencia_General).HasMaxLength(500);
            entityBuilder.Property(x => x.Experiencia_Especifica).HasMaxLength(500);
            entityBuilder.Property(x => x.Dni).IsRequired().HasMaxLength(8);
            entityBuilder.Property(x => x.Ruc).IsRequired().HasMaxLength(11);
            entityBuilder.Property(x => x.CCI).HasMaxLength(50);
            entityBuilder.Property(x => x.Nro_Celular).HasMaxLength(9);
            

        }
    }
}
