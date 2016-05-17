using MathApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MathApi.Controllers
{
    public class CalculatorController : ApiController
    {
        private Calculator calc = new Calculator();

        [HttpGet]
        public HttpResponseMessage Get(double v1, double v2, string op)
        {
            Operation operation = new Operation(v1, v2, op);
            System.Diagnostics.Debug.WriteLine("***********Controller************");
            System.Diagnostics.Debug.WriteLine(calc.operate(operation));
            calc.operate(operation);
            var res = Request.CreateResponse<Operation>(System.Net.HttpStatusCode.Created, operation);
            return res;
        }
    }
}
