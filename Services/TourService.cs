using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPB_semestral_project_Version2.Services;
using IPB_semestral_project_Version2.Models;

namespace IPB_semestral_project_Version2.Services
{
    public class TourService : ITourService
    {
        private List<Formulation> Formulations = new List<Formulation>();

        private void FillFormulations()
        {
            Formulations.Add(new Formulation { Id = 1, CountryName = "Turkey", CityName = "Ankara", Budget = 3000, QuantityOfPeronsForTour = 2 });
            Formulations.Add(new Formulation { Id = 2, CountryName = "Poland", CityName = "Warszawa", Budget = 13000, QuantityOfPeronsForTour = 4 });
            Formulations.Add(new Formulation { Id = 3, CountryName = "The United States of America", CityName = "Washington", Budget = 1000, QuantityOfPeronsForTour = 1 });
            Formulations.Add(new Formulation { Id = 4, CountryName = "Poland", CityName = "Warszawa", Budget = 500, QuantityOfPeronsForTour = 3 });
        }
        public TourService() 
        {
            FillFormulations();
        }

        public IEnumerable<Formulation> GetFormulation() 
        {
            return Formulations.ToArray();
        }

    }
}
