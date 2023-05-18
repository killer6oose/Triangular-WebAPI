using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Triangular.API.RequestBodies;
using Triangular.BLL;
using Triangular.BLL.Calculators.GridReferenceCalculators;

namespace Triangular.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class GridTriangleReferenceCalculationController : Controller
    {
        private readonly GridReferenceByTriangleCalculator Calculator;

        public GridTriangleReferenceCalculationController(GridReferenceByTriangleCalculator calculator)
        {
            this.Calculator = calculator;
        }

        // POST: api/GridTriangleReferenceCalculation
        [HttpPost]
        public JsonResult Post([FromBody] CreateGridTriangleReferenceCalculationRequestBody request)
        {
            Grid grid = new Grid(request.GridHeight, request.GridWidth, request.CellSize);

            Triangle triangle = new Triangle()
                .AddAngleCoordinate(new Coordinate(request.V1X, request.V1Y))
                .AddTopLeftCoordinate(new Coordinate(request.V2X, request.V2Y))
                .AddBottomRightCoordinate(new Coordinate(request.V3X, request.V3Y));

            IGridReference gridReference = this.Calculator.Calculate(grid, triangle);

            return Json(gridReference);
        }
    }
}
