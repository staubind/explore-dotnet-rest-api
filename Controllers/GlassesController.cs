using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GlassesModel.Models;

namespace seeSharpEyewear.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GlassesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<GlassesController> _logger;

        public GlassesController(ILogger<GlassesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Glasses> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Glasses
            {
                Name = "hi",
                Color = "blue",
                Shape = "circle"
            })
            .ToArray();
        }
    }
}
