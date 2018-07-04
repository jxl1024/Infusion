using Infusion.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infusion.Domain.Repository
{
  public  interface IInfusionSeatRepository
    {
        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        List<InfusionSeat> GetAll();

        /// <summary>
        /// 增加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(InfusionSeat infusionSeat); 

        /// <summary>
        /// 根据id删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

        /// <summary>
        /// 根据实体修改数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(InfusionSeat infusionSeat); 
    }
}
