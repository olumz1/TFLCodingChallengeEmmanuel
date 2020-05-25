using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Response;

namespace TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Interface
{
    public interface IRoadService
    {
        Task<RoadStatusResponseDto> RoadStatusService(string id);
    }
}
