using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFacExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoFacExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
            private readonly IDataProvider dataProvider;

            public ValueController(IDataProvider dataProvider)
            {
                this.dataProvider = dataProvider;
            }

            // GET api/value
            [HttpGet]
            public string Get()
            {
                return dataProvider.Get();
            }
    }
}