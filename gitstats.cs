using System;

namespace Gitstats
{
    public class GitstatClient
    {
        public class Users
        {
            fetch_api api = new fetch_api();

             public dynamic FetchUserId(string Username)
            {
                api.GetUserId(Username);    
            }
        }
    }
}
