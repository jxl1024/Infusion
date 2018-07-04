using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class InfusionDeptMap : IEntityTypeConfiguration<InfusionDept>
    {
        public void Configure(EntityTypeBuilder<InfusionDept> builder)
        {
            // 表名
            builder.ToTable("InfusionDept");
            // 主键
            builder.HasKey(p => p.RdId);
            // 属性
            builder.Property(p => p.RoomId).HasColumnType("int").IsRequired();
            builder.Property(p => p.DeptNo).HasColumnType("varchar(32)");
            builder.Property(p => p.DeptName).HasColumnType("varchar(64)");
            builder.Property(p => p.IsDel).HasColumnType("bit").HasDefaultValue(0);
            builder.Property(p => p.Memo).HasColumnType("varchar(max)");
            builder.Property(p => p.UpdateUser).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETDATE()");
        }
    }
}
