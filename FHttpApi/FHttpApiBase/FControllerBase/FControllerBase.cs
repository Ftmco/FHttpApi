using FHttpApi.ObjectResults;
using FTeam.FHttpApi.ResultModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FTeam.FHttpApiBase.FControllerBase
{
    public class FControllerBase : ControllerBase
    {
        /// <summary>
        /// Null Ok Object Result To Client
        /// </summary>
        /// <returns>a null instance of FOkObjectResult</returns>
        public async Task<FOkObjectResult> FOk() => await Task.Run(() => new FOkObjectResult(new FObjectResultModel()));

        /// <summary>
        /// send FOkObjectResult to client with 200 status code 
        /// </summary>
        /// <param name="objectResult">FOkObjectResult</param>
        /// <returns>an instance  of FOkObjectResult with your values</returns>
        public async Task<FOkObjectResult> FOk(FOkObjectResult objectResult) => await Task.Run(() =>
        {
            if (objectResult == null)
            {
                throw new ArgumentNullException(nameof(objectResult));
            }
            return objectResult;
        });

        /// <summary>
        /// send FOkObjectResult to client with 200 status  code 
        /// </summary>
        /// <param name="objectResult">FObjectResultModel</param>
        /// <returns>an instance of FOkObjectResult with FObjectResultModel value</returns>
        public async Task<FOkObjectResult> FOk(FObjectResultModel objectResult) => await Task.Run(() =>
        {
            if (objectResult == null)
            {
                throw new ArgumentNullException(nameof(objectResult));
            }
            return new FOkObjectResult(objectResult);
        });

        /// <summary>
        /// System Exceptions With 200 Status Code 
        /// </summary>
        /// <returns>FOkObjectResult</returns>
        public async Task<FOkObjectResult> SystemException() => await Task.Run(() => new FOkObjectResult(new FObjectResultModel { Code = "2", Title = "System Exception", Result = new { } }));
    }
}
