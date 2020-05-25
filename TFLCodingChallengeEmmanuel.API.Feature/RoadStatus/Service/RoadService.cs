using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Interface;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Request;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Response;

namespace TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Service
{
    public class RoadService : IRoadService
    {
        private readonly IRoadApi _roadApi;
        private readonly IConfiguration _configuration;
        private readonly IMapper _autoMapper;

        public RoadService(IRoadApi roadApi, IConfiguration configuration, IMapper autoMapper)
        {
            _roadApi = roadApi;
            _configuration = configuration;
            _autoMapper = autoMapper;
        }

        public async Task<RoadStatusResponseDto> RoadStatusService(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new Exception("No road Id was entered");

            var appId = _configuration.GetSection("TFL:AppId").Value;
            var appKey = _configuration.GetSection("TFL:AppKey").Value;
            var baseUrl = _configuration.GetSection("TFL:DataEndPoint").Value;

            var roadStatusRequest = new RoadStatusRequest
            {
                Id = id,
                AppId = appId,
                AppKey = appKey,
                BaseUrl = baseUrl
            };

            try
            {
                var tflRequest = await _roadApi.RoadStatus(roadStatusRequest);
                var result = _autoMapper.Map<RoadStatusResponseDto>(tflRequest);

                return result;
            }
            catch
            {
                return null;
            }

          
        }
    }
}
