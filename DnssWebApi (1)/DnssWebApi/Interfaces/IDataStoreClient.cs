using DnssWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnssWebApi
{
    interface IDataStoreClient
    {

        Task<List<AdmaModel>> GetAllData();
        Task<List<AdmaModel>> GetDataById(int Id);
        Task<List<AdmaModel>> GetDataByType(string type);
        Task<List<AdmaModel>> GetDataByUnit(string unit);

        Task<bool> UpdateData(string Id, string newComment);
        Task<bool> DeleteRecord(string Id);
        Task<bool> WriteNewData(AdmaModel newData);


    }
}
