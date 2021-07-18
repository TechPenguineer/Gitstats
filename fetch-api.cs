using System;
using System.Collections.Generic;
using System.Text;

namespace Gitstats
{

    class fetch_api
    {
        public void get_api()
        {

        }
        public void GetUserId(string Username)
        {
            string apiRefference = $"https://api.github.com/users/{Username}";
        }
    }
}
