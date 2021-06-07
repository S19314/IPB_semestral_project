using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPB_semestral_project_Version2.Models
{
    [Serializable]
    public class TourOption
    {
        public int Id { get; set; }
        public string RestType { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
