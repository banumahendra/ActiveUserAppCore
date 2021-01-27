using ActiveUserAppBACore.Contractor;
using ActiveUserAPPCoreDAO_T.Manager;
using ActiveUserAppDATA;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace ActiveUserAppBALTest
{
    public class UserRepositoryTest
    {
        //private readonly Mock<ILogger<UserRepositoryBO>> _logger;
        //private readonly Mock<IUserRepositoryDAO> userRepositoryDAO;

        //public UserRepositoryTest()
        //{

        //}

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            var userRepositoryDAOMock = new Mock<IUserRepositoryDAO>();
            var logger = new Mock<ILogger<UserRepositoryBO>>();
            userRepositoryDAOMock.Setup(x => x.GetUsers()).Returns
                (
                new List<User>()
                {
                    new User() 
                    { Id =1, Email="abc@abc.com", Name="Test", Phone="1111111" ,IsActive=true  }
                }
                );


            var userRepositoryBO = new UserRepositoryBO(userRepositoryDAOMock.Object, logger.Object);
            var users = userRepositoryBO.GetUserDetails();
            Assert.NotNull(users);
            Assert.AreEqual(1, users.Count);
        }
    }
}