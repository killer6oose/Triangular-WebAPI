using APITest.Calculators.TriangleCalculators;
using Microsoft.AspNetCore.Mvc;
using Triangular.API.RequestBodies;
using Triangular.BLL;

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GridTriangleCalculationController : Controller
    {
        private readonly ITriangleByGridReferenceCalculator _calculator;

        public GridTriangleCalculationController(ITriangleByGridReferenceCalculator calculator)
        {
            _calculator = calculator;
        }

        // POST: api/GridTriangleCalculation
        [HttpPost]
        public JsonResult Post([FromBody] CreateGridTriangleCalculationRequestBody request)
        {
            Grid grid = new Grid(request.GridHeight, request.GridWidth, request.CellSize);

            GridReference gridReference = new GridReference(request.GridReference);

            return Json(_calculator.Calculate(grid, gridReference).Coordinates);
        }
    }
}