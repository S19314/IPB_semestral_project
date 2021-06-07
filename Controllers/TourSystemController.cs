using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPB_semestral_project_Version2.Services;
using IPB_semestral_project_Version2.Models;

namespace IPB_semestral_project_Version2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TourSystemController : ControllerBase
    {
        private readonly ITourService TourService;

        public TourSystemController(ITourService tourService)
        {
            this.TourService = tourService;
        }

        [HttpGet]
        public IEnumerable<Formulation> Get()
        {
            return TourService.GetFormulation();
        }
    }
}
