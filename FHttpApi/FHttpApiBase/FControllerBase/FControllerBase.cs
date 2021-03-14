using FHttpApi.ObjectResults;
using FTeam.FHttpApi.ResultModels;
using FTeam.FHttpApiStaticFunctions.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FTeam.FHttpApiBase.FControllerBase
{
    /// <summary>
    /// Friends Team Controller Base Extend ControllerBase 
    /// </summary>
    public class FControllerBase : ControllerBase
    {
        private readonly IOkResults _okResults;

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
        /// use 'await'
        /// </summary>
        /// <returns>FOkObjectResult</returns>
        public async Task<FOkObjectResult> SystemExceptionAsync() => await Task.Run(async () => await _okResults.GetSystemExceptionResultAsync());

        public FOkObjectResult SystemException() => _okResults.GetSystemExceptionResult();
    }
}
