using DnssWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnssWebApi
{
    public static class Extension
    {
        public static AdmaModel AsDtoAdmaModel(this AdmaModel model)
        {
            return new AdmaModel
            {
                ID = model.ID,
                Name = model.Name,
                CurrentWeight = model.CurrentWeight,
                WantedWeight = model.WantedWeight,
                Bmi = model.Bmi,
                Height = model.Height
            };
        }


    }
}
