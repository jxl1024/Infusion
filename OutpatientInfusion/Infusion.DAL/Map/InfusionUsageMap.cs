using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class InfusionUsageMap : IEntityTypeConfiguration<InfusionUsage>
    {
        public void Configure(EntityTypeBuilder<InfusionUsage> builder)
        {
            // 表名
            builder.ToTable("InfusionUsage");
            // 主键
            builder.HasKey(p => p.ItemId);
            // 属性
            builder.Property(p => p.RoomId).HasColumnType("int");
            builder.Property(p => p.UsageNo).HasColumnType("varchar(16)");
            builder.Property(p => p.UsageName).HasColumnType("varchar(32)");
            builder.Property(p => p.IsDel).HasColumnType("bit").HasDefaultValue(0);
            builder.Property(p => p.Memo).HasColumnType("varchar(max)");
            builder.Property(p => p.UpdateUser).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETDATE()");
        }
    }
}
