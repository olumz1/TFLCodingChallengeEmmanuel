using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Service;

namespace TFLCodingChallengeEmmanuel.Test
{
    public class TestBase
    {
        protected IMapper CurrentMapper;

        public TestBase()
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(RoadService).Assembly);
            });

            mockMapper.AssertConfigurationIsValid();
            CurrentMapper = mockMapper.CreateMapper();
        }
    }
}
