using System.Collections.Generic;

namespace User
{
    public class User
    {

        public User()
        {
        }

        public void Add(string username)
        {
            UserList.Instance.Users.Add(username);
        }

        public int GetUsersCount()
        {
            return UserList.Instance.Users.Count;
        }
    }
}
