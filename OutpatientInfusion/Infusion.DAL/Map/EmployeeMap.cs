using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // 表名
            builder.ToTable("Employee");

            // 主键
            builder.HasKey(p=>p.EmpId);

            // 属性
            builder.Property(p => p.EmpNo).HasColumnType("varchar(16)");
            builder.Property(p => p.EmpName).HasColumnType("varchar(32)");
            builder.Property(p => p.Sex).HasColumnType("char(1)");
            builder.Property(p => p.IdNo).HasColumnType("varchar(20)");
            builder.Property(p => p.Birthday).HasColumnType("datetime");
            builder.Property(p => p.EmpType).HasColumnType("char(1)");
            builder.Property(p => p.SpellCode).HasColumnType("varchar(16)");
            builder.Property(p => p.WbCode).HasColumnType("varchar(16)");
            builder.Property(p => p.IsDel).HasColumnType("bit").HasDefaultValue(0);
            builder.Property(p => p.Memo).HasColumnType("varchar(max)");
            builder.Property(p => p.UpdateUser).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.Password).HasColumnType("varchar(32)");
        }
    }
}
