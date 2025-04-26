using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace addressbook_tests_autoit.Tests
{
    public class GroupDeleteTests : TestBase
    {
        [Test]
        public void TestGroupDelete()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Delete();
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.That(oldGroups, Is.EqualTo(newGroups));


        }
    }
}
