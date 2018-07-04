using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class InfusionRoomMap : IEntityTypeConfiguration<InfusionRoom>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<InfusionRoom> builder)
        {
            // 表名
            builder.ToTable("InfusionRoom");
            // 主键
            builder.HasKey(p => p.RoomId);

            // 属性
            builder.Property(p => p.RoomCode).HasColumnType("varchar(64)");
            builder.Property(p => p.RoomName).HasColumnType("varchar(64)");
            //builder.Property(p => p.DrugUsageCode).HasColumnType("varchar(256)");
            builder.Property(p => p.PrescriptionDays).HasColumnType("decimal(10,2)");
            //builder.Property(p => p.PharmacyCode).HasColumnType("varchar(256)");
            builder.Property(p => p.Mode).HasColumnType("bit");
            builder.Property(p => p.Memo).HasColumnType("varchar(max)");
            builder.Property(p => p.UpdateUser).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.IsDel).HasColumnType("bit").HasDefaultValue(0);

            // 关系
            // 配置一对多关系: 一个输液室可以对应多个科室
            builder.HasMany(m => m.InfusionDepts).WithOne(o => o.InfusionRoom).HasForeignKey(p => p.RoomId);
            // 一个输液室可以有多种药品用法
            builder.HasMany(m => m.InfusionUsages).WithOne(o => o.InfusionRoom).HasForeignKey(p => p.RoomId);
            // 一个输液室可以对应多个药房
            builder.HasMany(m => m.Pharmacys).WithOne(o => o.InfusionRoom).HasForeignKey(p => p.RoomId);
        }
    }
}
