﻿using System;
using System.Collections.Generic;
using System.Text;
using Gitstats;

namespace Gitstats.tests
{
    class gitstat_test
    {
        public void getID()
        {
            GitstatClient.GetUserJSON("TechPenguineer");
        }
       
    }
}
