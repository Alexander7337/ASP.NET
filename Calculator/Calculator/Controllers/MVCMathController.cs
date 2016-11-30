using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;
using System.ComponentModel.DataAnnotations;

namespace Calculator.Controllers
{
    public class MVCMathController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            CalculatorModel model = new CalculatorModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult Index(CalculatorModel model)
        {
            MathUtils mathUtils = new MathUtils();

            string operation = model.Submit;

            switch (operation)
            {
                case "Add":
                        model.Result = mathUtils.Add(model.FirstNumber, model.SecondNumber);
                    break;
                case "Substract":
                    model.Result = mathUtils.Substract(model.FirstNumber, model.SecondNumber);
                    break;
                case "Multiply":
                    model.Result = mathUtils.Multiply(model.FirstNumber, model.SecondNumber);
                    break;
                case "Divide":
                    model.Result = mathUtils.Divide(model.FirstNumber, model.SecondNumber);
                    break;
                default:
                    break;
            }

            return View(model);
        }


    }

    public class CalculatorModel
    {
        [Required]
        public double FirstNumber { get; set; }

        [Required]
        public double SecondNumber { get; set; }

        public double Result { get; set; }

        public string Submit { get; set; }
    }
}
