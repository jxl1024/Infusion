using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class InfusionPatientMap : IEntityTypeConfiguration<InfusionPatient>
    {
        public void Configure(EntityTypeBuilder<InfusionPatient> builder)
        {
            // 表名
            builder.ToTable("InfusionPatient");
            // 主键
            builder.HasKey(p => p.InfusionId);
            // 属性
            builder.Property(p => p.RoomId).HasColumnType("int").IsRequired();
            builder.Property(p => p.SeatId).HasColumnType("int").IsRequired();
            builder.Property(p => p.QueueNo).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.ChartNo).HasColumnType("varchar(16)").IsRequired(false);
            builder.Property(p => p.VisitNo).HasColumnType("varchar(16)").IsRequired(false);
            builder.Property(p => p.PtName).HasColumnType("varchar(32)").IsRequired(false);
            builder.Property(p => p.Sex).HasColumnType("char(1)").IsRequired(false);
            builder.Property(p => p.Age).HasColumnType("int");
            builder.Property(p => p.BirthDay).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.CardNo).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.CheckInTime).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.Checkiner).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.Auditor).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.AuditTime).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.Configer).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.ConfigTime).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.Starter).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.StartTime).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.Ender).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.EndTime).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.Status).HasColumnType("bit").IsRequired();
            builder.Property(p => p.Canceler).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.CancelTime).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.DeptNo).HasColumnType("varchar(16)").IsRequired(false);
            builder.Property(p => p.Child).HasColumnType("bit").IsRequired();
            builder.Property(p => p.Emg).HasColumnType("bit").IsRequired();
            builder.Property(p => p.PrescriptionNo).HasColumnType("varchar(16)").IsRequired(false);
            builder.Property(p => p.SpecialDrug).HasColumnType("bit").IsRequired();
            builder.Property(p => p.DischargeMedication).HasColumnType("bit").IsRequired();
            builder.Property(p => p.MedUsageNo).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.Receipt).HasColumnType("varchar(64)").IsRequired(false);
            builder.Property(p => p.Memo).HasColumnType("varchar(64)").IsRequired(false);

        }
    }
}
