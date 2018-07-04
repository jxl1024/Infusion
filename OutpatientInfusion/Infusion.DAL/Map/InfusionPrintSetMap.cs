using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class InfusionPrintSetMap : IEntityTypeConfiguration<InfusionPrintSet>
    {
        public void Configure(EntityTypeBuilder<InfusionPrintSet> builder)
        {
            // 配置生成的表名
            builder.ToTable("InfusionPrintSet");
            // 配置主键
            builder.HasKey(p => p.Id);
            // 配置属性
            builder.Property(p => p.PrintSetCode).HasColumnType("varchar(128)").IsRequired();
            builder.Property(p => p.PrintSetName).HasColumnType("varchar(128)").IsRequired();
            builder.Property(p => p.Memo).HasColumnType("varchar(max)");
            builder.Property(p => p.UpdateUser).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.IsDel).HasColumnType("bit").HasDefaultValue(0);
        }
    }
}
