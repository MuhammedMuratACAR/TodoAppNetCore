using ACARProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class GorevMap : IEntityTypeConfiguration<Gorev>
    {
        public void Configure(EntityTypeBuilder<Gorev> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Ad).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Aciklama).HasColumnType("ntext");
            builder.HasOne(I => I.Aciliyet).WithMany(I => I.Gorevler).HasForeignKey(I => I.AciliyetId);   
        }
    }
}
