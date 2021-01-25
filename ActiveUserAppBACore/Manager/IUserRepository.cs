using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActiveUserAppBACore.Manager
{
    public interface IUserRepositoryBO
    {
        List<User> GetUserDetails();
    }
}
