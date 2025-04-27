using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
           var oldGroups = app.Groups.GetGroupCount();

            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };

            app.Groups.Add(newGroup);
            Assert.That(oldGroups + 1, Is.EqualTo(app.Groups.GetGroupCount()));
            
        }
    }
}
