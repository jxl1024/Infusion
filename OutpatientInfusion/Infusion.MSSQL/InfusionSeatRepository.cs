using Infusion.Common.Entities;
using Infusion.DAL;
using Infusion.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infusion.MSSQL
{
    public class InfusionSeatRepository : IInfusionSeatRepository
    {
        public bool Add(InfusionSeat infusionSeat)
        {
            bool tfSuccess = false;
            try
            {
                using (var dbContext = new EFInfusionDbContext())
                {
                    // 设置状态为新增
                    dbContext.Entry(infusionSeat).State = EntityState.Added;
                    tfSuccess = dbContext.SaveChanges() > 0 ? true : false;
                }
            }
            catch(Exception ex)
            {

            }
            return tfSuccess;
        }

        public bool Delete(int id)
        {
            bool tfSuccess = false;
            try
            {
                using (var dbContext = new EFInfusionDbContext())
                {
                    InfusionSeat infusionSeat = new InfusionSeat()
                    {
                        SeatId = id
                    };
                    // 设置状态是删除
                    dbContext.Entry(infusionSeat).State = EntityState.Deleted;
                    tfSuccess = dbContext.SaveChanges() > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {

            }
            return tfSuccess;
        }

        public List<InfusionSeat> GetAll()
        {
            List<InfusionSeat> list = new List<InfusionSeat>();
            using (var dbContext = new EFInfusionDbContext())
            {
                list = dbContext.InfusionSeats.ToList<InfusionSeat>();
            }
            return list;
        }

        public bool Modify(InfusionSeat infusionSeat)
        {       
            bool tfSuccess = false;
            try
            {
                using (var dbContext = new EFInfusionDbContext())
                {
                    var del = false;
                    while(!del)
                    {
                        try
                        {
                            // 设置状态为修改
                            dbContext.Entry(infusionSeat).State = EntityState.Modified;
                            tfSuccess = dbContext.SaveChanges() > 0 ? true : false;
                            del = true;
                        }
                        catch(DbUpdateException ex)
                        {
                            foreach (var entry in ex.Entries)
                            {
                               if(entry.Entity is InfusionSeat)
                                {
                                    var proposedValues = entry.CurrentValues;
                                    var databaseValues = entry.GetDatabaseValues();

                                    foreach(var property in proposedValues.Properties)
                                    {
                                        var proposedValue = proposedValues[property];
                                        var databaseValue = databaseValues[property];
                                    }

                                    entry.OriginalValues.SetValues(databaseValues);
                                }
                               else
                                {
                                    throw new NotSupportedException(
                       "Don't know how to handle concurrency conflicts for "
                       + entry.Metadata.Name);
                                }
                            }
                        }
                    }
                  
                }
            }
            catch (Exception ex)
            {

            }
            return tfSuccess;
        }
    
    }
}
