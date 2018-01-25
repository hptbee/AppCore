using System.Collections.Generic;
using AppCore.Infrastructure.ViewModels;

namespace AppCore.Service.IService
{
    public interface IFlexUserService
    {
        IEnumerable<FlexUsersViewModel> GetAll();
    }
}