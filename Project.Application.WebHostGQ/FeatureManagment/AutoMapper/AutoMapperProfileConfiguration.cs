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
            #region PriceRepertory 
            CreateMap<PriceRepertoryGridAction, VMPriceRepertoryGridAction>()
                 .ForMember(vm => vm.Id, map => map.MapFrom(m => m.TBL_BprID))
                 .ForMember(vm => vm.TBL_BprParentID_fk, map => map.MapFrom(m => m.TBL_BprParentID_fk))
                 .ForMember(vm => vm.HasChildren, map => map.MapFrom(m => m.TBL_BprHasChildren))
                 .ForMember(vm => vm.Name, map => map.MapFrom(m => m.TBL_BprDescription));


            //CreateMap<object,ProjectManagementSystemProjectReportPlanItems>();            
            //.ForMember(dst => dst, opt => opt.ResolveUsing(src => Newtonsoft.Json.JsonConvert.DeserializeObject(src.ToString())));

            #endregion


            #region ProjectManagementSystem
            CreateMap<PostProjectManagementSystemProjectPhysicalExtend, VMProjectManagementSystemProjectPhysicalExtend>()
                .ForMember(vm => vm.WOS_WoID_fk, map => map.MapFrom(m => m.WOS_WoID_fk))
                .ForMember(vm => vm.PhysicalExtend_Name, map => map.MapFrom(m => m.Name))
                .ForMember(vm => vm.PMS_WbsprActive, map => map.MapFrom(m => m.PMS_WbsprActive))
                .ForMember(vm => vm.PMS_WbsprDate, map => map.MapFrom(m => m.PMS_WbsprDate))
                .ForMember(vm => vm.PMS_WbsprLetterDate, map => map.MapFrom(m => m.PMS_WbsprLetterDate))
                .ForMember(vm => vm.PMS_WbsprNote, map => map.MapFrom(m => m.PMS_WbsprNote))
                .ForMember(vm => vm.PMS_WbsprPhysicalAdvancementPercent, map => map.MapFrom(m => m.PMS_WbsprPhysicalAdvancementPercent))
                .ForMember(vm => vm.PMS_WbsprTitle, map => map.MapFrom(m => m.PMS_WbsprTitle))
                .ForMember(vm => vm.WOS_WotName, map => map.MapFrom(m => m.WOS_WotName))
                .ForMember(vm => vm.PMS_WbsprLetterNo, map => map.MapFrom(m => m.PMS_WbsprLetterNo));


            #endregion

            #region user
            //CreateMap<UserRequest, User>()
            //     .ForMember<Organization>(d => d.Organization, m => m.MapFrom((s => s.Organization)));//.AfterMap((src, dest) => Mapper.Map(src.Organization,dest.Organization.Id));
            #endregion

        }

    }
}
