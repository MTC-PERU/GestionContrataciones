using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTC.Model;

namespace MTC.Persistence.Database.Config
{
    public class TerminoReferenciaConfig
    {
        public TerminoReferenciaConfig(EntityTypeBuilder<TerminoReferencia> entityBuilder)
        {
            entityBuilder.Property(x => x.Objeto).HasMaxLength(500);
            entityBuilder.Property(x => x.FinalidadPublica).HasMaxLength(500);
            entityBuilder.Property(x => x.DuracionServicio).HasMaxLength(50);
            entityBuilder.Property(x => x.FormaPago).HasMaxLength(50);
            entityBuilder.Property(x => x.Sueldo).IsRequired();
            entityBuilder.Property(x => x.ImporteTotal).IsRequired();
            entityBuilder.Property(x => x.NumOrdenServicio).HasMaxLength(500);
            
        }
        
    }
}
