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
        public AutoMapperProfileConfiguration(): this("MyProfile")
        {
        }
        protected AutoMapperProfileConfiguration(string profileName): base(profileName)
        {
            #region ProjectManagementSystem
            CreateMap<PriceRepertoryGridAction, VMPriceRepertoryGridAction>()
                 .ForMember(vm => vm.Id, map => map.MapFrom(m => m.TBL_BprID))
                 .ForMember(vm => vm.TBL_BprParentID_fk, map => map.MapFrom(m => m.TBL_BprParentID_fk))
                 .ForMember(vm => vm.HasChildren, map => map.MapFrom(m => m.TBL_BprHasChildren))
                 .ForMember(vm => vm.Name, map => map.MapFrom(m => m.TBL_BprDescription));
                 

            //CreateMap<object,ProjectManagementSystemProjectReportPlanItems>();            
            //.ForMember(dst => dst, opt => opt.ResolveUsing(src => Newtonsoft.Json.JsonConvert.DeserializeObject(src.ToString())));

            #endregion

            #region user
            //CreateMap<UserRequest, User>()
            //     .ForMember<Organization>(d => d.Organization, m => m.MapFrom((s => s.Organization)));//.AfterMap((src, dest) => Mapper.Map(src.Organization,dest.Organization.Id));
            #endregion

        }

    }
}
