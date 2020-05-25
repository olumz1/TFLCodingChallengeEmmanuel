using System;
using System.Collections.Generic;
using System.Text;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Response;
using Xunit;

namespace TFLCodingChallengeEmmanuel.Test
{
    
    public class RoadStatusMapperTest : TestBase
    {
        [Fact]
        public void GivenRoadStatusResponseShouldMapToRoadStatusResponseDto()
        {
            var input = new RoadStatusResponse
            {
                Type = "Tfl.Api.Presentation.Entities.RoadCorridor, Tfl.Api.Presentation.Entities",
                Id = "a2",
                DisplayName = "A2",
                StatusSeverity = "Good",
                StatusSeverityDescription = "No Exceptional Delays",
                Bounds = "[[-0.0857,51.44091],[0.17118,51.49438]]",
                Envelope = "[[-0.0857,51.44091],[-0.0857,51.49438],[0.17118,51.49438],[0.17118,51.44091],[-0.0857,51.44091]]",
                Url = "/Road/a2"
            };

            var outPutRoadStatusResponseDto = CurrentMapper.Map<RoadStatusResponseDto>(input);

            Assert.Equal(input.DisplayName, outPutRoadStatusResponseDto.DisplayName);
            Assert.Equal(input.StatusSeverity, outPutRoadStatusResponseDto.StatusSeverity);
            Assert.Equal(input.StatusSeverityDescription, outPutRoadStatusResponseDto.StatusSeverityDescription);
        }

        
    }
}
