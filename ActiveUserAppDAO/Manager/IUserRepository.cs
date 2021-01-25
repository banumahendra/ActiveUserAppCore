using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActiveUserAppDAO.Manager
{
    public interface IUserRepository
    {
        List<User> GetUserDetails();
    }
}
