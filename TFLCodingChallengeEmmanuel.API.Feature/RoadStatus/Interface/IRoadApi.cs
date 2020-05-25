using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Request;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Response;

namespace TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Interface
{
    public interface IRoadApi
    {
        Task<RoadStatusResponse> RoadStatus(RoadStatusRequest roadStatusRequest);
    }
}
