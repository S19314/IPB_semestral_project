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
        private readonly ITourService TourService = new TourService();
        private readonly ILogger<TourSystemController> _logger;
        public TourSystemController(ILogger<TourSystemController> logger)
        {
            _logger = logger;
        }

        /*
        public TourSystemController(ITourService tourService)
        {{
            this.TourService = tourService;
        }
        */

        [Route("formulation")]
        [HttpGet]
        public IEnumerable<Formulation> GetFormulations()
        {
            return TourService.GetFormulations();
        }
        
        
        [Route("formulationwithaddinfo")]
        [HttpGet]
        public IEnumerable<Formulation> GetFormulationsWithAdditionalInfo()
        {
            return TourService.GetFormulationsWithAdditionalInfo();
        }

        
        [Route("option")]
        [HttpGet]
        public IEnumerable<TourOption> GetTourOptions()
        {
            return TourService.GetTourOptions();
        }
        
        [Route("option/{id}")]
        [HttpGet]
        public TourOption GetTourOptionsById(int id)
        {
            return TourService.GetTourOptionById(id);
        }
    }
}
