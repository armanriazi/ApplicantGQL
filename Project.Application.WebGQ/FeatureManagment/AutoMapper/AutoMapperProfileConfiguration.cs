using AutoMapper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using GQ;

namespace Project.Application.WebHostGQ.FeatureManagment.AutoMapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        : this("MyProfile")
        {
        }
        protected AutoMapperProfileConfiguration(string profileName)
        : base(profileName)
        {
            #region ProjectManagementSystem
            CreateMap<JToken, ProjectManagementSystemReport>();          
            #endregion

            #region user
            //CreateMap<UserRequest, User>()
            //     .ForMember<Organization>(d => d.Organization, m => m.MapFrom((s => s.Organization)));//.AfterMap((src, dest) => Mapper.Map(src.Organization,dest.Organization.Id));
            #endregion

        }

    }
}
