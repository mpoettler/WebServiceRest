using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DnssWebApi.Dto
{
    public class CreateModelDto
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public double CurrentWeight { get; set; }

        [Required]
        public double WantedWeight { get; set; }

        public int Bmi { get; set; }

        [Required]
        public int Height { get; set; }

    }
}
