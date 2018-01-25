using System;
using AppCore.Entity.Models;
using AppCore.Infrastructure.ViewModels;
using AutoMapper;

namespace AppCore.Config.Mapper
{
    public class MappingsProfileService : Profile
    {
        public MappingsProfileService()
        {
            CreateMap();
        }

        protected MappingsProfileService(string profileName) : base(profileName)
        {
        }

        protected MappingsProfileService(string profileName, Action<IProfileExpression> configurationAction) : base(profileName, configurationAction)
        {
        }

        public override string ProfileName => GetType().FullName;

        protected void CreateMap()
        {
            CreateMap<FlexUsersViewModel, FlexUsers>();
        }
    }
}
