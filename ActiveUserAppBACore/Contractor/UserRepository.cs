using ActiveUserAppBACore.Manager;
using ActiveUserAPPCoreDAO_T.Manager;
using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActiveUserAppBACore.Contractor
{
    public class UserRepositoryBO : IUserRepositoryBO

    {
        private readonly IUserRepositoryDAO userRepositoryDAO;

        public UserRepositoryBO(IUserRepositoryDAO userRepository)
        {
            userRepositoryDAO = userRepository;
        }
        public List<User> GetUserDetails()
        {
            return userRepositoryDAO.GetUsers();
        }
    }
}
