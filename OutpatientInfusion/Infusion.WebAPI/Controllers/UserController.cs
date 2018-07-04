using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infusion.Common.Entities;
using Infusion.DAL;
using log4net;
using Microsoft.AspNetCore.Hosting;
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
        private ILog log;

        /// <summary>
        /// 通过构造函数注入日志
        /// </summary>
        /// <param name="hostingEnv"></param>
        public UserController(IHostingEnvironment hostingEnv)
        {
            this.log = LogManager.GetLogger(Startup.repository.Name, typeof(UserController));
        }

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
                    log.Info("获取用户成功!");
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