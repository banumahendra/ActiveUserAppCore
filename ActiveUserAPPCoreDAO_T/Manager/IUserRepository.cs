using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActiveUserAPPCoreDAO_T.Manager
{
    public interface IUserRepositoryDAO
    {
        List<User> GetUsers();
    }
}
