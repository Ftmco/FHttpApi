using FHttpApi.ObjectResults;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FTeam.FHttpApiBase.FControllerBase
{
    public class FControllerBase : ControllerBase
    {
        public async Task<FOkObjectResult> FOk(FOkObjectResult objectResult) => await Task.Run(() => objectResult);
    }
}
