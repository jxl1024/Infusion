using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infusion.Common.Entities;
using Infusion.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Json;
using Newtonsoft.Json;

namespace Infusion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{empNo}")]
        public string GetUser(string empNo)
        {
            using (var dbContext = new EFInfusionDbContext())
            {
                Employee employee= dbContext.Employees.FirstOrDefault(p => p.EmpNo.Equals(empNo));
                if(employee!=null)
                {
                    // if(employee.Password.Equals(pwd))
                    //{
                    return "成功";
                    //}
                    // else
                    //{
                    //    return "密码不正确";
                    //}
                    //return   Json()
                }
                else
                {
                    return "用户不存在";

                    //return 
                }
            }
                //return "测试";
        }
    }
}