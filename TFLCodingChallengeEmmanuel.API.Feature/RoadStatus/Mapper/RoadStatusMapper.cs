using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Response;

namespace TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Mapper
{
    public class RoadStatusMapper : Profile
    {
        public RoadStatusMapper()
        {
            CreateMap<RoadStatusResponse, RoadStatusResponseDto>(MemberList.None);
        }
    }
}
