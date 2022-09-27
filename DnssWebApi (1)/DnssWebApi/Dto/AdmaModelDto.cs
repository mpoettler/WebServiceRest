using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnssWebApi.Dto
{
    public class AdmaModelDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double CurrentWeight { get; set; }
        public double WantedWeight { get; set; }
        public int Bmi { get; set; }
        public int Height { get; set; }
    }
}
