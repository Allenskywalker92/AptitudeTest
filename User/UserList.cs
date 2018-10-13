using System.Collections.Generic;

namespace User
{
    public class UserList
    {
        private static UserList instance;
        public List<string> Users { get; set; }

        public UserList()
        {
            Users = new List<string>();
        }

        public static UserList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserList();
                }
                return instance;
            }
        }
    }
}
