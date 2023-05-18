using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Triangular.API.RequestBodies
{
    public class CreateGridTriangleCalculationRequestBody
    {
        [Required]
        [DataType(DataType.Text)]
        public string GridReference { get; set; }

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
