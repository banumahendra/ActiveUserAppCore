using ActiveUserAPPCoreDAO_T.Context;
using ActiveUserAPPCoreDAO_T.Manager;
using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveUserAPPCoreDAO_T.Contractor
{
    public class UserRepositoryDAO : IUserRepositoryDAO
    {
        private readonly UserDBContext _context;
        public UserRepositoryDAO(UserDBContext context)
        {
            _context = context;
        }
        public List<User> GetUsers()
        {
            return _context.User.ToList();
        }
    }
}
