using System;
using System.Collections.Generic;
using ACF.Application.Contracts.UserManagement;
using ACF.Domain.Persistance.Repositories.StaffManagement;
using ACF.Infrastructure.Core;
using ACF.Infrastructure.SQLContext;

namespace ACF.Application.Services.UserManagement
{
    public class UserManagementService : BaseService, IUserManagementService
    {
        IStaffRepository _userRepository;

        public UserManagementService(
            IACFUnitOfWorkFactory unitOfWorkFactory,
            IStaffRepository userRepository) 
            : base(unitOfWorkFactory)
        {
            Check.NotNull(userRepository, "userRepository");

            _userRepository = userRepository;
        }

        public List<UserDto> GetByUserName(string userName)
        {
            var users = _userRepository.GetByUserName(userName);
            var result = new List<UserDto>();
            foreach (var item in users)
            {
                result.Add(new UserDto
                {
                    Email = item.Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Password = item.Password,
                    UserName = item.UserName
                });
            }

            return result;
        }

        public void Update(UserDto userDto)
        {
            using (var context = base.unitOfWorkFactory.Create())
            {
                var user = _userRepository.GetById(userDto.Id);
                if (user != null)
                {
                    user.FirstName = userDto.FirstName;
                    _userRepository.Modify(user);

                    context.Commit();
                }
            }
        }

        public UserDto Add(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (_userRepository != null)
            {
                this._userRepository.UnitOfWork.Dispose();
            }
        }

    }
}
