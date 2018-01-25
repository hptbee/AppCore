using System.Collections.Generic;
using AppCore.Entity.Models;
using AppCore.Infrastructure.ViewModels;
using AppCore.Repository.IRepositories;
using AppCore.Service.IService;
using AutoMapper;

namespace AppCore.Service.Service
{
    public class FlexUserService : IFlexUserService
    {
        private readonly IFlexUserRepository _flexUserRepository;
        public FlexUserService(IFlexUserRepository flexUserRepository)
        {
            _flexUserRepository = flexUserRepository;
        }

        public IEnumerable<FlexUsersViewModel> GetAll()
        {
            var result = _flexUserRepository.GetAll();
            return Mapper.Map<IEnumerable<FlexUsers>, IEnumerable<FlexUsersViewModel>>(result);
        }
    }
}
