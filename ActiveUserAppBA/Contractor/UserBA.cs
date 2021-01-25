using ActiveUserAppBA.Manager;
using ActiveUserAppDAO.Contractor;
using ActiveUserAppDAO.Manager;
using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Text;


namespace ActiveUserAppBA.Contractor
{
    public class UserBA : IUser
    {
        private readonly IUserRepository userRepositoryDAO;

        public UserBA()
        {
            userRepositoryDAO = new UserRepository();
        }
        public UserBA(IUserRepository userRepository)
        {
            userRepositoryDAO = userRepository;
        }
        public List<User> GetUserDetails()
        {
            return userRepositoryDAO.GetUserDetails();
        }
    }
}
