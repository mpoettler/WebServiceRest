using DnssWebApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DnssWebApi
{
    public interface IInMemModelRepo
    {
        Task <AdmaModel> GetModel(string name);

        Task <IEnumerable<AdmaModel>> GetModels();

        Task <AdmaModel> GetVersion(string type);

        Task CreateModel(AdmaModel model);
    }
}