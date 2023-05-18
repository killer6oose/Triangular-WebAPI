using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Triangular.API.RequestBodies
{
    public class CreateGridTriangleReferenceCalculationRequestBody
    {
        [Required]
        [Range(0, 100)]
        public int V1X { get; set; }

        [Required]
        [Range(0, 100)]
        public int V1Y { get; set; }

        [Required]
        [Range(0, 100)]
        public int V2X { get; set; }

        [Required]
        [Range(0, 100)]
        public int V2Y { get; set; }

        [Required]
        [Range(0, 100)]
        public int V3X { get; set; }

        [Required]
        [Range(0, 100)]
        public int V3Y { get; set; }

        [Required]
        [Range(1, 100)]
        public int GridHeight { get; set; }

        [Required]
        [Range(1, 100)]
        public int GridWidth { get; set; }

        [Required]
        [Range(1, 100)]
        public int CellSize { get; set; }
    }
}
