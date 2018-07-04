using Infusion.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL.Map
{
    public class InfusionPnDetailMap : IEntityTypeConfiguration<InfusionPnDetail>
    {
        public void Configure(EntityTypeBuilder<InfusionPnDetail> builder)
        {
            // 表名
            builder.ToTable("InfusionPnDetail");
            // 主键
            builder.HasKey(p => p.IpdId);
            // 属性
            builder.Property(p => p.InfusionId).HasColumnType("int").IsRequired(false);
            builder.Property(p => p.PrescriptionNo).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.SeqNo).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.DrugCode).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.DrugName).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.DrugStandard).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.DrugDepartmentName).HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.DrugNum).HasColumnType("int").IsRequired();
            builder.Property(p => p.DrugDose).HasColumnType("int").IsRequired();
            builder.Property(p => p.DrugDoseUnit).HasColumnType("varchar(32)").IsRequired(false);
            builder.Property(p => p.GroupId).HasColumnType("int").IsRequired();
            builder.Property(p => p.RecordStatus).HasColumnType("int").IsRequired();
            builder.Property(p => p.DoctorNo).HasColumnType("varchar(32)").IsRequired(false);
            builder.Property(p => p.PrescriptionDate).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.Memo).HasColumnType("varchar(max)").IsRequired(false);
            builder.Property(p => p.FrequencyNo).HasColumnType("varchar(32)").IsRequired(false);
            builder.Property(p => p.UsageNo).HasColumnType("varchar(32)").IsRequired(false);
            builder.Property(p => p.KeepTime).HasColumnType("datetime").IsRequired(false);
            builder.Property(p => p.TotQty).HasColumnType("int").IsRequired(false);
            builder.Property(p => p.ExecQty).HasColumnType("int").IsRequired(false);
            builder.Property(p => p.TotComposeQty).HasColumnType("int").IsRequired(false);
            builder.Property(p => p.Advise).HasColumnType("varchar(32)").IsRequired(false);
            builder.Property(p => p.IsCharge).HasColumnType("bit").IsRequired(false);
            builder.Property(p => p.ChargeNo).HasColumnType("int").IsRequired(false);
            builder.Property(p => p.IsSkinTest).HasColumnType("bit");
            builder.Property(p => p.SkinTestResult).HasColumnType("varchar(128)").IsRequired(false);
        }
    }
}
