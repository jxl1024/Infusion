using Infusion.Common.Entities;
using Infusion.DAL.Map;
using Infusion.Framework.Manager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.DAL
{
    public class EFInfusionDbContext:DbContext
    {
        /// <summary>
        /// 配置连接字符串
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 从json文件里面读取连接字符串
            string strConn = JsonManager.GetValue("ConnectionString");
            // 配置数据库连接，并设置生成的迁移记录表的表名称
            optionsBuilder.UseSqlServer(strConn, p => p.MigrationsHistoryTable("_InfusionMigrationHistory"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 不将BaseEntity映射到数据库表
            modelBuilder.Ignore<BaseEntity>();
            modelBuilder.ApplyConfiguration<Dept>(new DeptMap());
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeMap());
            modelBuilder.ApplyConfiguration<InfusionBadnessEvent>(new InfusionBadnessEventMap());
            modelBuilder.ApplyConfiguration<InfusionDept>(new InfusionDeptMap());
            modelBuilder.ApplyConfiguration<InfusionPatient>(new InfusionPatientMap());
            modelBuilder.ApplyConfiguration<InfusionPnDetail>(new InfusionPnDetailMap());
            modelBuilder.ApplyConfiguration<InfusionPrintSet>(new InfusionPrintSetMap());
            modelBuilder.ApplyConfiguration<InfusionRoom>(new InfusionRoomMap());
            modelBuilder.ApplyConfiguration<InfusionSeat>(new InfusionSeatMap());
            modelBuilder.ApplyConfiguration<InfusionSpecialDrug>(new InfusionSpecialDrugMap());
            modelBuilder.ApplyConfiguration<InfusionUsage>(new InfusionUsageMap());
            modelBuilder.ApplyConfiguration<Pharmacy>(new PharmacyMap());
            base.OnModelCreating(modelBuilder);
        }

        #region DbSet属性
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<InfusionBadnessEvent> InfusionBadnessEvents { get; set; }
        public DbSet<InfusionDept> InfusionDepts { get; set; }
        public DbSet<InfusionPatient> InfusionPatients { get; set; }
        public DbSet<InfusionPnDetail> InfusionPnDetails { get; set; }
        public DbSet<InfusionPrintSet> InfusionPrintSets { get; set; }
        public DbSet<InfusionRoom> InfusionRooms { get; set; }
        public DbSet<InfusionSeat> InfusionSeats { get; set; }
        public DbSet<InfusionSpecialDrug> InfusionSpecialDrugs { get; set; }
        public DbSet<InfusionUsage> InfusionUsages { get; set; }
        public DbSet<Pharmacy> Pharmacys { get; set; } 
        #endregion
    }
}
