using DnssWebApi.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DnssWebApi
{
    public static class Properties /*: IParameters*/
    {

        //192.168.88.30\api\v1\cmd\cmd_measurement_start.json
        public static async Task<bool> StartMessuarementAsync()
        {
            HttpRequestMessage requestMessage = new(HttpMethod.Post, @"192.168.88.30\api\v1\cmd\cmd_measurement_start.json");
            HttpClient httpClient = new();
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            return response.IsSuccessStatusCode;
        }

        //192.168.88.30\api\v1\cmd\cmd_measurement_stop.json
        public static async Task<bool> StopMessuarement()
        {
            HttpRequestMessage requestMessage = new(HttpMethod.Post, @"192.168.88.30\api\v1\cmd\cmd_measurement_stop.json");
            HttpClient httpClient = new();
            var response = await httpClient.SendAsync(requestMessage);
            return response.IsSuccessStatusCode;
        }

        //192.168.88.30\api\v1\cmd\cmd_config_save.json
        public static async Task<bool> SaveSettings()
        {
            HttpRequestMessage requestMessage = new(HttpMethod.Put, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            HttpClient httpClient = new();
            var response = await httpClient.SendAsync(requestMessage);
            return response.IsSuccessStatusCode;
        }

        /* 
         192.168.88.30\api\v1\config\parameter\mounting\config_mounting_angle_adma_x.json
         192.168.88.30\api\v1\config\parameter\mounting\config_mounting_angle_adma_y.json
         192.168.88.30\api\v1\config\parameter\mounting\config_mounting_angle_adma_z.json
         */
        public static async Task<bool> setMountingAngle(int angleZ)
        {
            HttpRequestMessage requestMessage = new(HttpMethod.Post, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");

            var client = new HttpClient();
            var requestJson = JsonConvert.SerializeObject(angleZ);
            requestMessage.Content = new StringContent(requestJson, Encoding.UTF8, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var response = await client.SendAsync(requestMessage);

            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> SetMountingOffsetAsync(int x, int y, int z)
        {
            HttpRequestMessage requestMessage = new(HttpMethod.Post, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var prop = new PropertiesObject(x,y,z);
            
            var client = new HttpClient();
            var requestJson = JsonConvert.SerializeObject(prop);
            requestMessage.Content = new StringContent(requestJson, Encoding.UTF8, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var response = await client.SendAsync(requestMessage);

            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> SetPositionPrimaryAntenna(int x, int y, int z)
        {
            HttpRequestMessage requestMessage = new(HttpMethod.Post, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var prop = new PropertiesObject(x, y, z);

            var client = new HttpClient();
            var requestJson = JsonConvert.SerializeObject(prop);
            requestMessage.Content = new StringContent(requestJson, Encoding.UTF8, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var response = await client.SendAsync(requestMessage);

            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> SetPositionSecondayAntenna(int x, int y, int z)
        {
            HttpRequestMessage requestMessage = new(HttpMethod.Post, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var prop = new PropertiesObject(x, y, z);

            var client = new HttpClient();
            var requestJson = JsonConvert.SerializeObject(prop);
            requestMessage.Content = new StringContent(requestJson, Encoding.UTF8, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var response = await client.SendAsync(requestMessage);

            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> SetPOI(int index, string name, int x, int y, int z)
        {
            HttpRequestMessage requestMessage = new(HttpMethod.Post, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var prop = new PropertiesObject(index,name,x,y,z);

            var client = new HttpClient();
            var requestJson = JsonConvert.SerializeObject(prop);
            requestMessage.Content = new StringContent(requestJson, Encoding.UTF8, @"192.168.88.30\api\v1\cmd\cmd_config_save.json");
            var response = await client.SendAsync(requestMessage);

            return response.IsSuccessStatusCode;
        }
    }
}
