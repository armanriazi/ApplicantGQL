using AutoMapper;
using GQ;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Application.WebHostGQ.FeatureManagment.AutoMapper
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.AddProfile(new AutoMapperProfileConfiguration());
                cfg.CreateMap<PriceRepertoryGridAction, VMPriceRepertoryGridAction>();
                cfg.CreateMap<ObjectGraphType, VMPriceRepertoryGridAction>();
                cfg.CreateMap<VMPriceRepertoryGridAction,ObjectGraphType>();
                cfg.CreateMap<ListGraphType, List<VMPriceRepertoryGridAction>>();
                cfg.CreateMap<List<VMPriceRepertoryGridAction>, ListGraphType>();
            });
            

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            //services.AddScoped(typeof(IMapper), typeof(Mapper));

        }
    }
}
