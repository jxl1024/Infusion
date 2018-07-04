using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    /// <summary>
    /// InfusionSeat表配置信息类
    /// </summary>
    public class InfusionSeatMap : IEntityTypeConfiguration<InfusionSeat>
    {
        /// <summary>
        /// InfusionSeat配置
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<InfusionSeat> builder)
        {
            // 配置生成的表名
            builder.ToTable("InfusionSeat");
            // 配置主键
            builder.HasKey(p => p.SeatId);
            // 属性
            builder.Property(p => p.InfusionId).HasColumnType("int").IsRequired(false);
            builder.Property(p => p.RoomId).HasColumnType("int").IsRequired(false);
            builder.Property(p => p.Plus).HasColumnType("smallint").IsRequired(false);
            builder.Property(p => p.Used).HasColumnType("smallint").IsRequired(false);
            builder.Property(p => p.Valid).HasColumnType("smallint").IsRequired(false);
            builder.Property(p => p.Child).HasColumnType("smallint").IsRequired(false);
            builder.Property(p => p.Special).HasColumnType("smallint").IsRequired(false);
            builder.Property(p => p.Memo).HasColumnType("VARCHAR(MAX)");
            builder.Property(p => p.UpdateUser).HasColumnType("VARCHAR(32)").IsRequired();
            builder.Property(p => p.UpdateTime).HasColumnType("datetime").HasDefaultValueSql("GETDATE()");
            //builder.Property(p => p.IsDel).HasColumnType("bit").HasDefaultValueSql(0);
        }
    }
}
