using Moq;
using System;
using System.Net;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Interface;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Request;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Response;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Service;
using Xunit;

namespace TFLCodingChallengeEmmanuel.Test
{
    public class RoadStatusTest : TestBase
    {
        [Fact]
        public void GivenAValidRoadIdReturnTrue()
        {
            var apiResponse = new RoadStatusResponse
            {
                Type = "Tfl.Api.Presentation.Entities.RoadCorridor, Tfl.Api.Presentation.Entities",
                Id = "A2",
                DisplayName = "A2",
                StatusSeverity = "Good",
                StatusSeverityDescription = "No Exceptional Delays",
                Bounds = "[[-0.0857,51.44091],[0.17118,51.49438]]",
                Envelope = "[[-0.0857,51.44091],[-0.0857,51.49438],[0.17118,51.49438],[0.17118,51.44091],[-0.0857,51.44091]]",
                Url = "/Road/a2"
            };
            var apiRequest = new RoadStatusRequest
            {
                AppId = "AppId",
                AppKey = "AppKey",
                BaseUrl = "DataEndPoint",
                Id = "A2"
            };

           
            var roadApi = new Mock<IRoadApi>();
            
            var configuration = new Mock<IConfiguration>();
            
            var mockConfAppId = new Mock<IConfigurationSection>();

            var mockConfAppKey = new Mock<IConfigurationSection>();

            var mockConfBaseUrl = new Mock<IConfigurationSection>();

            mockConfAppId.Setup(a => a.Value).Returns("AppId");
            mockConfAppKey.Setup(a => a.Value).Returns("AppKey");
            mockConfBaseUrl.Setup(a => a.Value).Returns("DataEndPoint");

            configuration.Setup(a => a.GetSection("TFL:AppId")).Returns(mockConfAppId.Object);
            configuration.Setup(a => a.GetSection("TFL:AppKey")).Returns(mockConfAppKey.Object);
            configuration.Setup(a => a.GetSection("TFL:DataEndPoint")).Returns(mockConfBaseUrl.Object);


            roadApi.Setup(x => x.RoadStatus(It.IsAny<RoadStatusRequest>())).ReturnsAsync(apiResponse);

            var sut = new RoadService(roadApi.Object, configuration.Object, CurrentMapper);

            var result = sut.RoadStatusService(apiRequest.Id).Result;

            Assert.Equal(apiResponse.DisplayName, result.DisplayName);
            Assert.Equal(apiResponse.StatusSeverity, result.StatusSeverity);
            Assert.Equal(apiResponse.StatusSeverityDescription, result.StatusSeverityDescription);
        }
    }
}
