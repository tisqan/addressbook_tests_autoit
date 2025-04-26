﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_autoit
{

    public class TestBase
    {
        protected ApplicationManager app;

        [OneTimeSetUp]
        public void InitApplicationMamnager()
        {
            app = new ApplicationManager();
        }

        [OneTimeTearDown]
        public void StopApplication()
        {
            app.Stop();
        }
        
    }
}
