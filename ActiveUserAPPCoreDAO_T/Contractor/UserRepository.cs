using ActiveUserAPPCoreDAO_T.Context;
using ActiveUserAPPCoreDAO_T.Manager;
using ActiveUserAppDATA;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveUserAPPCoreDAO_T.Contractor
{
    public class UserRepositoryDAO : IUserRepositoryDAO
    {
        private readonly ILogger<UserRepositoryDAO> _logger;
        private readonly UserDBContext _context;
        public UserRepositoryDAO(UserDBContext context, ILogger<UserRepositoryDAO> logger)
        {
            _context = context;
            _logger = logger;
        }
        public List<User> GetUsers()
        {
            _logger.LogInformation("Entered into GetUsers Method,  UserRepositoryDAO Class");
            
            List<User> result;
            try
            {
               result = _context.User.ToList();

                if (result == null)
                {
                    result = new List<User>();
                    _logger.LogInformation("No Records fetched from DATABASE ,GetUsers Method,  UserRepositoryDAO Class");
                }
                else
                {
                    _logger.LogInformation($"{result.Count} - Records fetched from DATABASE ,GetUsers Method,  UserRepositoryDAO Class");
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Error occured in GetUsers, UserRepositoryDAO Class", ex.Message);
                result = null;
            }

            _logger.LogInformation("Returning from GetUsers, UserRepositoryDAO Class");
            return result;
        }
    }
}
