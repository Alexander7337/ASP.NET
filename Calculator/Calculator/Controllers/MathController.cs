using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calculator.Controllers
{
    [RoutePrefix("api/math")]
    public class MathController : ApiController
    {
        [HttpGet]
        public double Get()
        {
            return 10;
        }

        [HttpGet]
        [Route("add")]
        public double Add(double firstNumber, int secondNumber)
        {
            double result = firstNumber + secondNumber;

            return result;
        }

        [HttpGet]
        [Route("substract")]
        public double Substract(double firstNumber, int secondNumber)
        {
            double result = firstNumber - secondNumber;

            return result;
        }

        [HttpGet]
        [Route("multiply")]
        public double Multiply(double firstNumber, int secondNumber)
        {
            double result = firstNumber * secondNumber;

            return result;
        }

        [HttpGet]
        [Route("divide")]
        public double Divide(double firstNumber, int secondNumber)
        {
            double result = firstNumber / secondNumber;

            return result;
        }
    }
}
