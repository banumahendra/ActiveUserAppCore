using ActiveUserAppBACore.Manager;
using ActiveUserAPPCoreDAO_T.Manager;
using ActiveUserAppDATA;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActiveUserAppBACore.Contractor
{
    public class UserRepositoryBO : IUserRepositoryBO
    {
        private readonly ILogger<UserRepositoryBO> _logger;
        private readonly IUserRepositoryDAO userRepositoryDAO;

        public UserRepositoryBO(IUserRepositoryDAO userRepository, ILogger<UserRepositoryBO> logger)
        {
            userRepositoryDAO = userRepository;
            _logger = logger;
        }
        public List<User> GetUserDetails()
        {
            _logger.LogInformation("Entered into GetUserDetails Method,  UserRepositoryBO Class");

            List<User> result;
            
            try
            {
                result = userRepositoryDAO.GetUsers();

                if(result == null || result?.Count == 0)
                {
                    result = new List<User>();
                    _logger.LogInformation("No Records fetched from DAL ,GetUserDetails Method,  UserRepositoryBO Class");
                }
                else
                {
                    _logger.LogInformation($"{result.Count} - Records fetched from DAL ,GetUserDetails Method,  UserRepositoryBO Class");
                }
            }
            catch(Exception ex)
            {
                _logger.LogInformation("Error occured in GetUserDetails, UserRepositoryBO Class", ex.Message);
                result = null;
            }

            _logger.LogInformation("Returning from GetUserDetails, UserRepositoryBO Class");
            return result;
        }
    }
}
