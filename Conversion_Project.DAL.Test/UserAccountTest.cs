using Conversion_Project.BL.Concrete;
using Conversion_Project.DAL.Abstact;
using Conversion_Project.Entities;
using Moq;
using NUnit.Framework;

namespace Conversion_Project.DAL.Test
{
    public class UserAccountTest
    {

        string username = "admin";
        string password = "1";
        UserAccountBusiness userAccountBusiness;

        [SetUp]
        public void Setup()
        {
            var mockRepo = new Mock<IUserAccountRepository>();
            mockRepo.Setup(repo => repo.GetUser(username, password)).Returns(
                (string _username, string _password) =>
                {
                    if (_username == "admin" && _password == "1")
                    {
                        return new UserAccount() { UserName = "admin", FirstName = "Emre", LastName = "Özbaşkan" };
                    }
                    else
                    {
                        return null;
                    }
                }
            );
            userAccountBusiness = new UserAccountBusiness(mockRepo.Object);
        }

        [Test]
        public void UserNotNullTest()
        {
            Assert.IsNotNull(userAccountBusiness.GetUser(username, password));
        }

        [Test]
        public void UserNullTest()
        {
            Assert.IsNull(userAccountBusiness.GetUser("admin", "123"));
        }

    }
}