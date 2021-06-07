using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB_semestral_project_Version2.Models
{
    [Serializable]
    public class Formulation
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public double Budget { get; set; }
        public int QuantityOfPeronsForTour { get; set; }
    }
}
