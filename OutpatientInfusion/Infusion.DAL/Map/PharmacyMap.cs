using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class PharmacyMap : IEntityTypeConfiguration<Pharmacy>
    {
        public void Configure(EntityTypeBuilder<Pharmacy> builder)
        {
            // 表名
            builder.ToTable("Pharmacy");

            // 主键
            builder.HasKey(p => p.Id);
            // 属性
            builder.Property(p => p.RoomId).HasColumnType("int");
            builder.Property(p => p.PharmacyCode).HasColumnType("varchar(16)").IsRequired();
            builder.Property(p => p.PharmacyName).HasColumnType("varchar(64)").IsRequired();
            builder.Property(p => p.Isdel).HasColumnType("bit").IsRequired().HasDefaultValue(0);
            builder.Property(p => p.Memo).HasColumnType("varchar(max)");
            builder.Property(p => p.UpdateUser).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETDATE()") ;

        }
    }
}
