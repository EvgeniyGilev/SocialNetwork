using SocialNetwork.DAL.Entities;
using System.Collections.Generic;

namespace SocialNetwork.DAL.Repositories
{
    public class FriendRepository : BaseRepository, IFriendRepository
    {
        public IEnumerable<FriendEntity> FindAllByUserId(int userId)
        {
            return Query<FriendEntity>(@"select * from friends where user_id = :user_id", new { user_id = userId });
        }

        public int Create(FriendEntity friendEntity)
        {
            return Execute(@"insert into friends (user_id,friend_id) values (:user_id,:friend_id)", friendEntity);
        }

        public int Delete(FriendEntity friendEntity)
        {
            return Execute(@"delete from friends where user_id = :user_id and friend_id =:friend_id", friendEntity);
        }

        public FriendEntity FindFirendId(FriendEntity friendEntity)
        {
            return QueryFirstOrDefault<FriendEntity>("select * from friends where user_id = :user_id and friend_id =:friend_id", friendEntity);
        }

    }

    public interface IFriendRepository
    {
        int Create(FriendEntity friendEntity);
        IEnumerable<FriendEntity> FindAllByUserId(int userId);
        int Delete(FriendEntity friendEntity);
        FriendEntity FindFirendId(FriendEntity friendEntity);

    }
}
