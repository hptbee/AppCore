using ACF.Application.Contracts.UserManagement;
using System;
using System.Collections.Generic;

namespace ACF.Application.Services.UserManagement
{
    public interface IUserManagementService : IDisposable
    {
        List<UserDto> GetByUserName(string userName);

        void Update(UserDto userDto);

        UserDto Add(UserDto userDto);

        void Delete(Guid Id);
    }
}
