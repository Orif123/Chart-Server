using Charts_Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Charts_Server.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : ControllerBase
    {
        List<ChartObject> chartObject = new List<ChartObject>()
        {
            new ChartObject
            {
                Id = 1,
            Company = "Matrix",
            Employees = new List<int>()
                {
                    7,10,15,42,35
                }
            },
            new ChartObject
            {
                 Id = 2,
                Company = "Apple",
                Employees = new List<int>()
                {
                    14,18,32,50,67
                }
                },
                new ChartObject
                {
                    Id = 3,
                    Company = "Intel",
                    Employees = new List < int >() 
                    {
                        9, 16, 20, 11, 3
                    }
            }
        };
        [EnableCors("CorsPolicy")]
        [HttpGet]
        public IEnumerable<ChartObject> GetCharts()
        {
            if (HttpContext.Request.Headers["Authorization"] == "1234")
            {
                return chartObject.ToList();
            }
            return null;
        }

    }
}

