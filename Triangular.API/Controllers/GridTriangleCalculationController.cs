using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Triangular.API.RequestBodies;
using Triangular.BLL;
using Triangular.BLL.Calculators.TriangleCalculators;

namespace Triangular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GridTriangleCalculationController : Controller
    {
        private readonly TriangleByGridReferenceCalculator Calculator;

        public GridTriangleCalculationController(TriangleByGridReferenceCalculator calculator)
        {
            this.Calculator = calculator;
        }

        // POST: api/GridTriangleCalculation
        [HttpPost]
        public JsonResult Post([FromBody] CreateGridTriangleCalculationRequestBody request)
        {
            Grid grid = new Grid(request.GridHeight, request.GridWidth, request.CellSize);

            GridReference gridReference = new GridReference(request.GridReference);

            return Json(this.Calculator.Calculate(grid, gridReference).Coordinates);
        }
    }
}
