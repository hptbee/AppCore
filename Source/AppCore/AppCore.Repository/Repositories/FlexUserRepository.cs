using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppCore.Repository.IRepositories;
using AppCore.Entity;
using AppCore.Entity.Models;

namespace AppCore.Repository.Repositories
{
    public class FlexUserRepository:  IFlexUserRepository
    {
        public IEnumerable<FlexUsers> GetAll()
        {
            using (var context = new AppCoreContext())
            {
                return context.FlexUsers.ToList();
            }
        }
    }
}
