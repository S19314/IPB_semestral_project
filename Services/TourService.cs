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
            Formulations.Add(new Formulation { Id = 1, CountryName = "Turkey", CityName = "Ankara", Budget = 3000, QuantityOfPeronsForTour = 2, StartDateTime = new DateTime(2022, 7, 15), EndDateTime = new DateTime(2022, 10, 15), IsAdditionalInfoSet = false });
            Formulations.Add(new Formulation { Id = 2, CountryName = "Poland", CityName = "Warszawa", Budget = 13000, QuantityOfPeronsForTour = 4, StartDateTime = new DateTime(2023, 4, 15), EndDateTime = new DateTime(2023, 5, 25), IsAdditionalInfoSet = false });
            Formulations.Add(new Formulation { Id = 3, CountryName = "The United States of America", CityName = "Washington", Budget = 1000, QuantityOfPeronsForTour = 1, StartDateTime = new DateTime(2021, 9, 15), EndDateTime = new DateTime(2021, 10, 15), IsAdditionalInfoSet = false });
            Formulations.Add(new Formulation { Id = 4, CountryName = "Poland", CityName = "Warszawa", Budget = 500, QuantityOfPeronsForTour = 3, StartDateTime = new DateTime(2022, 7, 15), EndDateTime = new DateTime(2022, 10, 15), IsAdditionalInfoSet = false });

            Formulations.Add(new Formulation { Id = 5, CountryName = "China", CityName = "Beijing", Budget = 3000, QuantityOfPeronsForTour = 2, StartDateTime = new DateTime(2022, 7, 15), EndDateTime = new DateTime(2022, 10, 15), IsAdditionalInfoSet = true, AdditionalInfo = "Please, add some food tour to main plan."  });
            Formulations.Add(new Formulation { Id = 6, CountryName = "Poland", CityName = "Warszawa", Budget = 13000, QuantityOfPeronsForTour = 4, StartDateTime = new DateTime(2023, 4, 15), EndDateTime = new DateTime(2023, 5, 25), IsAdditionalInfoSet = true, AdditionalInfo = "Please, add more nature plan to main plan." });
        }
        public TourService() 
        {
            FillFormulations();
        }

        public IEnumerable<Formulation> GetFormulations() 
        {
            return Formulations.ToArray();
        }

        public IEnumerable<Formulation> GetFormulationsWithAdditionalInfo()
        {
            return Formulations
                .Where(e => e.IsAdditionalInfoSet == true)
                .ToArray();
        }

    }
}
