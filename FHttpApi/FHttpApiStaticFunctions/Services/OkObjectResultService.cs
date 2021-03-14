using FHttpApi.ObjectResults;
using FTeam.FHttpApi.ResultModels;
using FTeam.FHttpApiStaticFunctions.Interfaces;
using System.Threading.Tasks;

namespace FTeam.FHttpApiStaticFunctions.Services
{
    public class OkObjectResultService : IOkResults
    {
        public FOkObjectResult GetOkEmptyResult()
        {
            return new FOkObjectResult(new FObjectResultModel());
        }

        public async Task<FOkObjectResult> GetOkEmptyResultAsync()
        {
            return await Task.Run(() => new FOkObjectResult(new FObjectResultModel()));
        }

        public FOkObjectResult GetSystemExceptionResult()
        {
            return new FOkObjectResult(new FObjectResultModel { Code = "2", Title = "System Exception", Result = new { } });
        }

        public async Task<FOkObjectResult> GetSystemExceptionResultAsync()
        {
            return await Task.Run(() => new FOkObjectResult(new FObjectResultModel { Code = "2", Title = "System Exception", Result = new { } });
        }
    }
}
