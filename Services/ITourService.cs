using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPB_semestral_project_Version2.Models;

namespace IPB_semestral_project_Version2.Services
{
    public interface ITourService
    {
        public IEnumerable<Formulation> GetFormulations();
        public IEnumerable<Formulation> GetFormulationsWithAdditionalInfo();
        public IEnumerable<TourOption> GetTourOptions();
        public TourOption GetTourOptionById(int id);
    }
}
