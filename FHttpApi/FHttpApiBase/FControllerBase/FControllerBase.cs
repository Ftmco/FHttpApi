using FHttpApi.ObjectResults;
using FTeam.FHttpApi.ResultModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FTeam.FHttpApiBase.FControllerBase
{
    public class FControllerBase : ControllerBase
    {
        public async Task<FOkObjectResult> FOk(FOkObjectResult objectResult) => await Task.Run(() => objectResult);

        public async Task<FOkObjectResult> FOk(FObjectResultModel objectResult) => await Task.Run(() => new FOkObjectResult(objectResult));

        public async Task<FOkObjectResult> FOk() => await Task.Run(() => new FOkObjectResult(new FObjectResultModel { Code = "2", Title = "System Exception", Result = new { } }));
    }
}
