﻿using API.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("error/{code}")]
    [ApiController]
    public class ErrorController : BaseApiController
    {
        public IActionResult Index(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }    
    }
}
