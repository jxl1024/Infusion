using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class InfusionSpecialDrugMap : IEntityTypeConfiguration<InfusionSpecialDrug>
    {
        public void Configure(EntityTypeBuilder<InfusionSpecialDrug> builder)
        {
            // 表名
            builder.ToTable("InfusionSpecialDrug");

            // 主键
            builder.HasKey(p => p.IsdId);

            // 属性
            builder.Property(p => p.OriginPlace).HasColumnType("varchar(64)");
            builder.Property(p => p.DrugCode).HasColumnType("varchar(16)");
            builder.Property(p => p.DrugName).HasColumnType("varchar(64)");
            builder.Property(p => p.DrugSpec).HasColumnType("varchar(64)");
            builder.Property(p => p.Color).HasColumnType("varchar(64)");
            builder.Property(p => p.IsDel).HasColumnType("bit").HasDefaultValue(0);
            builder.Property(p => p.Memo).HasColumnType("varchar(max)");
            builder.Property(p => p.UpdateUser).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETDATE()");
        }
    }
}
