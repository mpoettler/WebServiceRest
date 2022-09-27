using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnssWebApi.Interfaces
{
    internal interface IParameters
    {

        Task<bool> SetPOI(int index, string name, int x, int y, int z);
        Task<bool> SetPositionPrimaryAntenna(int x,int y,int z);
        Task<bool> SetPositionSecondayAntenna(int x,int y,int z);
        Task<bool> SetMountingOffsetAsync(int x,int y,int z);
        Task<bool> setMountingAngle(int angleZ);
        Task<bool> StartMessuarementAsync();
        Task<bool> StopMessuarement();
        Task<bool> SaveSettings();
    }
}
