using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class DeletingFriendView
    {
        UserService userService;
        public DeletingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var UserDeletingFriendData = new UserDeletingFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя которого хотите удалить из друзей: ");

                UserDeletingFriendData.FriendEmail = Console.ReadLine();
                UserDeletingFriendData.UserId = user.Id;

                userService.DeleteFriend(UserDeletingFriendData);

                SuccessMessage.Show("Вы успешно удалили пользователя из друзей!");
            }

            catch(UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }
            
            catch(Exception)
            {
                AlertMessage.Show("Произошла ошибка при удалении пользователя в друзьях!");
            }
        }
    }
}
