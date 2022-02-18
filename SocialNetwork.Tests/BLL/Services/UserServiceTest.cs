using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Interfaces;

namespace SocialNetwork.Tests.BLL.Services
{
    [TestFixture] 
    public class UserServiceTests
    {
        /// <summary>
        /// проверяем, что поиск по email вернет id пользователя
        /// </summary>
        [Test]
        public void FindByEmailReturnIdTest()
        {
            var mockUserReposiroty = new Mock<IUserRepository>();

            UserEntity userEntity = new UserEntity
            {
                id = 1,
                firstname = "Ivan",
                lastname = "Ivanov",
                password = "12345678",
                email = "test1@gmail.com",
                photo = null,
                favorite_movie = null,
                favorite_book = null
            };

            mockUserReposiroty.Setup(p => p.FindByEmail("test1@gmail.com")).Returns(userEntity);
            var userService = new UserService(mockUserReposiroty.Object);
            userService.FindByEmail("test1@gmail.com");

            Assert.True(1 == userService.FindByEmail("test1@gmail.com").Id);
        }
    }
}
