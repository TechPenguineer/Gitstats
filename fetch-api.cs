using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Linq;
using Gitstats;

namespace Gitstatsc
{   

    
    class fetch_api
    {
        public class user
        {
            public static user call(string Username)
            {
                string url = "https://api.github.com/";
                string urlParamaters = $"users/{Username}";
                var response = CallApi.RunAsync<user>(url, urlParamaters).GetAwaiter().GetResult();
                Console.WriteLine(response);
                return response;
            }
        }
    }
}
