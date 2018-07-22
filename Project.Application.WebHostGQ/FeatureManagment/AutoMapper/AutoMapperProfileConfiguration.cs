using AutoMapper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using GQ;

namespace Project.Application.WebHostGQ.FeatureManagment.AutoMapper
{
    //public class AutoMapperProfileConfiguration : Profile
    //{
    //    public AutoMapperProfileConfiguration()
    //    : this("MyProfile")
    //    {
    //    }
    //    protected AutoMapperProfileConfiguration(string profileName)
    //    : base(profileName)
    //    {
    //        #region ProjectManagementSystem
    //        //CreateMap<JObject, ProjectManagementSystemProjectReportPlanItems>();
    //        //CreateMap<object,ProjectManagementSystemProjectReportPlanItems>();            
    //        //.ForMember(dst => dst, opt => opt.ResolveUsing(src => Newtonsoft.Json.JsonConvert.DeserializeObject(src.ToString())));

    //        #endregion

    //        #region user
    //        //CreateMap<UserRequest, User>()
    //        //     .ForMember<Organization>(d => d.Organization, m => m.MapFrom((s => s.Organization)));//.AfterMap((src, dest) => Mapper.Map(src.Organization,dest.Organization.Id));
    //        #endregion

    //    }

    //}
}
