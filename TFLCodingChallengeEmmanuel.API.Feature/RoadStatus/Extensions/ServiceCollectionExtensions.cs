using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Interface;
using TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Service;

namespace TFLCodingChallengeEmmanuel.API.Feature.RoadStatus.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRoadFeature(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRoadService, RoadService>();
            serviceCollection.AddScoped<IRoadApi, RoadApi>();
        }
    }
}
