//Develop Custome Http Restfull api Response 
//Friends Team Co 
//https://github.com/ftmco

namespace FTeam.FHttpApi.ResultModels
{
    /// <summary>
    /// Friends Ok Object Result 
    /// </summary>
    public class FObjectResultModel
    {
        /// <summary>
        /// Ok Status Or Error Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Response Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Response Result Object
        /// </summary>
        public object Result { get; set; }
    }
}
