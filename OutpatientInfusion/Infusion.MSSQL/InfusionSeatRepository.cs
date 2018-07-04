using Infusion.Common.Entities;
using Infusion.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.MSSQL
{
    public class InfusionSeatRepository : IInfusionSeatRepository
    {
        public bool Add(InfusionSeat infusionSeat)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<InfusionSeat> GetAll()
        {
            List<InfusionSeat> list = new List<InfusionSeat>()
            {
              new InfusionSeat()
              {
                  InfusionId=1,
                  Memo="备注",
                  UpdateUser="Admin",
                  UpdateTime=DateTime.Now
              }
            };
            return list;
        }

        public bool Modify(InfusionSeat infusionSeat)
        {
            throw new NotImplementedException();
        }
    }
}
