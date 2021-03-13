using FHttpApi.ObjectResults;
using FTeam.FHttpApi.ResultModels;
using FTeam.FHttpApiBase.FControllerBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : FControllerBase
    {
        public async Task<IActionResult> Test()
        {
            return await FOk(new FObjectResultModel { Code = "0", Title = "Success", Result = new { } }
        }
    }
