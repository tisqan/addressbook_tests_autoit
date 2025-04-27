using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace addressbook_tests_autoit
{
    public class GroupDeleteTests : TestBase
    {
        [Test]
        public void TestGroupDelete()
        {
            var oldGroups = app.Groups.GetGroupCount();
            if (oldGroups == 0)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "test"
                };
                app.Groups.Add(newGroup);
            }

            app.Groups.Delete();
            Assert.That(oldGroups - 1, Is.EqualTo(app.Groups.GetGroupCount()));


        }
    }
}
