using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class DeptMap : IEntityTypeConfiguration<Dept>
    {
        public void Configure(EntityTypeBuilder<Dept> builder)
        {
            builder.ToTable("Dept");
            // 主键
            builder.HasKey(p => p.DeptId);
            // 属性
            builder.Property(p => p.DeptNo).HasColumnType("varchar(16)");
            builder.Property(p => p.DeptNo).HasColumnType("varchar(64)");
            builder.Property(p => p.SpellCode).HasColumnType("varchar(32)");
            builder.Property(p => p.WbCode).HasColumnType("varchar(32)");
            builder.Property(p => p.Memo).HasColumnType("varchar(max)");
            builder.Property(p => p.UpdateUser).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.IsDel).HasColumnType("bit").HasDefaultValue(0);
        }
    }
}
