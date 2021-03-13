using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHttpApi.ObjectResults
{
    public class FOkObjectRestult : OkObjectResult
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void ExecuteResult(ActionContext context)
        {
            base.ExecuteResult(context);
        }

        public override Task ExecuteResultAsync(ActionContext context)
        {
            return base.ExecuteResultAsync(context);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void OnFormatting(ActionContext context)
        {
            base.OnFormatting(context);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
