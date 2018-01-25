using System.Collections.Generic;
using AppCore.Entity.Models;

namespace AppCore.Repository.IRepositories
{
    public interface IFlexUserRepository
    {
        IEnumerable<FlexUsers> GetAll();
    }
}