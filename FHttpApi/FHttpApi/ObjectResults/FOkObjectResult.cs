using FTeam.FHttpApi.ResultModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace FHttpApi.ObjectResults
{
    [DefaultStatusCode(DefaultStatusCode)]
    public class FOkObjectResult : ObjectResult
    {
        //Default Status Code
        private const int DefaultStatusCode = StatusCodes.Status200OK;

        public FOkObjectResult(FObjectResultModel objectResult) : base(objectResult)
        {
            StatusCode = DefaultStatusCode;
        }
    }
}
