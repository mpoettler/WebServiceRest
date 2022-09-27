using DnssWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnssWebApi
{
    public class InMemModelRepo : IInMemModelRepo
    {
        private readonly List<AdmaModel> models = new()
        {
            new AdmaModel
            {
                CurrentWeight = 95.4,
                WantedWeight = 78,
                Height = 174,
                Name = "Matthias"
            }
        };

        public async Task <IEnumerable<AdmaModel>> GetModels() => await Task.FromResult(models);

        public async Task<AdmaModel> GetModel(string name)
        {
            var model = models.SingleOrDefault(model => model.Name == name);
            return await Task.FromResult(model);
        }

        public async Task<AdmaModel> GetVersion(string name)
        {
            var model = models.Where(model => model.Name == name).SingleOrDefault();
            return await Task.FromResult(model);
        }

        public async Task CreateModel(AdmaModel model)
        {
            models.Add(model);
            await Task.CompletedTask;
        }
    }
}
