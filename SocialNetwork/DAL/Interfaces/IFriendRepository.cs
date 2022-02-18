using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Entities;

namespace SocialNetwork.DAL.Interfaces
{
    public interface IFriendRepository
    {
        int Create(FriendEntity friendEntity);
        IEnumerable<FriendEntity> FindAllByUserId(int userId);
        int Delete(FriendEntity friendEntity);
        FriendEntity FindFirendId(FriendEntity friendEntity);

    }
}
