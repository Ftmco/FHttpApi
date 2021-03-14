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
    public abstract class FControllerBase : ControllerBase
    {
        /// <summary>
        /// Ok Results Service
        /// </summary>
        private readonly IOkResults _okResults;

        //+++++++++++++++++++++++++++++++++++OK Object Results++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //----------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Send Empty Ok Object Result To Client
        /// use 'await'
        /// </summary>
        /// <returns>an empty instance of FOkObjectResult</returns>
        public virtual async Task<FOkObjectResult> FOkAsync() => await Task.Run(async () => await _okResults.GetOkEmptyResultAsync());

        /// <summary>
        /// Send Empty Ok Object Result To client 
        /// </summary>
        /// <returns>an empty instance of FOkObjectResult</returns>
        public virtual FOkObjectResult FOk() => _okResults.GetOkEmptyResult();

        /// <summary>
        /// send FOkObjectResult to client with 200 status code 
        /// use 'await'
        /// </summary>
        /// <param name="objectResult">FOkObjectResult</param>
        /// <returns>an instance  of FOkObjectResult with your values</returns>
        public virtual async Task<FOkObjectResult> FOkAsync(FOkObjectResult objectResult) => await Task.Run(() =>
        {
            if (objectResult == null)
            {
                throw new ArgumentNullException(nameof(objectResult));
            }
            return objectResult;
        });

        /// <summary>
        ///  send FOkObjectResult to client with 200 status code 
        /// </summary>
        /// <param name="objectResult">FOkObjectResult</param>
        /// <returns>an instance  of FOkObjectResult with your value</returns>
        public virtual FOkObjectResult FOk(FOkObjectResult objectResult)
        {
            if (objectResult == null)
            {
                throw new ArgumentNullException(nameof(objectResult));
            }
            return objectResult;
        }

        /// <summary>
        /// send FOkObjectResult to client with 200 status  code 
        /// </summary>
        /// <param name="objectResult">FObjectResultModel</param>
        /// <returns>an instance of FOkObjectResult with FObjectResultModel value</returns>
        public virtual async Task<FOkObjectResult> FOkAsync(FObjectResultModel objectResult) => await Task.Run(() =>
        {
            if (objectResult == null)
            {
                throw new ArgumentNullException(nameof(objectResult));
            }
            return new FOkObjectResult(objectResult);
        });

        /// <summary>
        /// send FOkObjectResult to client with 200 status  code 
        /// </summary>
        /// <param name="objectResult">FObjectResultModel</param>
        /// <returns>an instance of FOkObjectResult with FObjectResultModel value</returns>
        public virtual FOkObjectResult FOk(FObjectResultModel objectResult)
        {
            if (objectResult == null)
            {
                throw new ArgumentNullException(nameof(objectResult));
            }
            return new FOkObjectResult(objectResult);
        }

        /// <summary>
        /// System Exceptions With 200 Status Code 
        /// use 'await'
        /// </summary>
        /// <returns>FOkObjectResult</returns>
        public virtual async Task<FOkObjectResult> SystemExceptionAsync() => await Task.Run(async () => await _okResults.GetSystemExceptionResultAsync());

        /// <summary>
        /// System Exception With 200 Status Code 
        /// </summary>
        /// <returns>FOkObjectResult</returns>
        public virtual FOkObjectResult SystemException() => _okResults.GetSystemExceptionResult();

        //----------------------------------------------------------------------------------------------------------------------------
        //+++++++++++++++++++++++++++++++++++OK Object Results++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /*################################### https://github.com/ftmco ###############################################################*/

        //+++++++++++++++++++++++++++++++++++Bad Request Object Results+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //----------------------------------------------------------------------------------------------------------------------------



        //----------------------------------------------------------------------------------------------------------------------------
        //+++++++++++++++++++++++++++++++++++Bad Request Object Results+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    }
}
