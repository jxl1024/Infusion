using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infusion.Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infusion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfusionSeatController : ControllerBase
    {
        [HttpGet]
        public List<InfusionSeat> GetAllInfusionSeat()
        {
            List<InfusionSeat> listSeat = new List<InfusionSeat>();
            return listSeat;
        }
    }
}