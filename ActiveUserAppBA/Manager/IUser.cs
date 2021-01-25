using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActiveUserAppBA.Manager
{
    public interface IUser
    {
        List<User> GetUserDetails();
    }
}
