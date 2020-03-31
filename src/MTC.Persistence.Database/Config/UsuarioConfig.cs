using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTC.Model;

namespace MTC.Persistence.Database.Config
{
    public class UsuarioConfig
    {
        public UsuarioConfig(EntityTypeBuilder<Usuario> entityBuilder)
        {
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.ApellidoPaterno).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.ApellidoMaterno).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.DNI).IsRequired().HasMaxLength(8);
            entityBuilder.Property(x => x.RUC).IsRequired().HasMaxLength(11);



        }
    }
}
