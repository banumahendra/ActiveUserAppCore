using ActiveUserAppDAO.Context;
using ActiveUserAppDAO.Manager;
using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace ActiveUserAppDAO.Contractor
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDBContext _context;

        public UserRepository()
        {
            _context = new UserDBContext();
        }
        public UserRepository(UserDBContext context)
        {
            _context = context;
        }
        public List<User> GetUserDetails()
        {
           return  _context.User.ToList();
        }
    }
}
