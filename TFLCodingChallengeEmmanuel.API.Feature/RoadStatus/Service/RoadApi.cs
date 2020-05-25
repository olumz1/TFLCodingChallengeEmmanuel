using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using log4net.Core;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Interface;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Request;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Response;

namespace TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Service
{
    public class RoadApi : IRoadApi
    {
        public async Task<RoadStatusResponse> RoadStatus(RoadStatusRequest roadStatusRequest)
        {
            var endPointUrl = $"{roadStatusRequest.BaseUrl}Road/{roadStatusRequest.Id}";
            using HttpClient client = new HttpClient();
            var builder = new UriBuilder(endPointUrl);
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["app_id"] = roadStatusRequest.AppId;
            query["app_key"] = roadStatusRequest.AppKey;
            builder.Query = query.ToString();
            var requestUrl = builder.ToString();
            client.BaseAddress = new Uri(requestUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(requestUrl).Result;

            
            if (!response.IsSuccessStatusCode) return null;

            var result =  await response.Content.ReadAsStringAsync();

            var roadStatusResponse = JsonConvert.DeserializeObject<List<RoadStatusResponse>>(result);

            return roadStatusResponse.FirstOrDefault();

        }
    }
}
