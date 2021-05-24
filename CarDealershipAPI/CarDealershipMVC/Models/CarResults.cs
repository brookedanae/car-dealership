using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipMVC.Models
{

    public class CarResults
    {
        public CarData[] Property1 { get; set; }
    }

    public class CarData
    {
        public int id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get; set; }
    }

}
