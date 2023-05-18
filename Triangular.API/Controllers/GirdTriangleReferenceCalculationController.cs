using Microsoft.AspNetCore.Mvc;
using Triangular.API.RequestBodies;
using Triangular.BLL.Models;
using Triangular.BLL.Services;

namespace Triangular.API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class GridTriangleReferenceCalculationController : Controller
    {
        private readonly IGridReferenceByTriangleCalculator _calculator;

        public GridTriangleReferenceCalculationController(IGridReferenceByTriangleCalculator calculator)
            => _calculator = calculator;

        // POST: api/GridTriangleReferenceCalculation
        [HttpPost]
        public JsonResult Post([FromBody] CreateGridTriangleReferenceCalculationRequestBody request)
        {
            Grid grid = new Grid(request.GridHeight, request.GridWidth, request.CellSize);

            Triangle triangle = new Triangle()
                .AddAngleCoordinate(new Coordinate(request.V1X, request.V1Y))
                .AddTopLeftCoordinate(new Coordinate(request.V2X, request.V2Y))
                .AddBottomRightCoordinate(new Coordinate(request.V3X, request.V3Y));

            IGridReference gridReference = _calculator.Calculate(grid, triangle);

            return Json(gridReference);
        }
    }
}