using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Mapper;

namespace TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Extensions
{
    public static class AutoMapperConfiguration
    {
        public static void AddMappingFeature(this IServiceCollection services) 
        {
            var mappingConfig = new MapperConfiguration(cfg => { cfg.AddProfile(new RoadStatusMapper()); });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        } 
    }
}
