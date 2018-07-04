using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class InfusionBadnessEventMap : IEntityTypeConfiguration<InfusionBadnessEvent>
    {
        public void Configure(EntityTypeBuilder<InfusionBadnessEvent> builder)
        {
            // 表名
            builder.ToTable("InfusionBadnessEvent");
            // 主键
            builder.HasKey(p => p.BnId);
            // 属性
            builder.Property(p => p.InfusionId).HasColumnType("int");
            builder.Property(p => p.RecorderId).HasColumnType("varchar(32)");
            builder.Property(p => p.RecorderName).HasColumnType("varchar(32)");
            builder.Property(p => p.Memo).HasColumnType("VARCHAR(MAX)");
            builder.Property(p => p.UpdateUser).HasColumnType("VARCHAR(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("DATETIME").IsRequired().HasDefaultValueSql("GETDATE()");
        }
    }
}
