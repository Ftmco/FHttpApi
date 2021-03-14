using FHttpApi.ObjectResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTeam.FHttpApiStaticFunctions.Interfaces
{
    public interface IOkResults
    {
        Task<FOkObjectResult> GetSystemExceptionResultAsync();

        FOkObjectResult GetSystemExceptionResult();
    }
}
