using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace mantis_tests
{
    [TestFixture]
    public class ProjectRemovalTests : ProjectManagementTestBase
    {

        [Test]
        public void RemoveProjectTest()
        {

            if (app.projectManagementHelper.GetProjectList().Count == 0)
            {
                ProjectData project = new ProjectData()
                {
                    Name = "Проект для удаления",
                    Description = "Этот проект создан для удаления",
                };
                app.projectManagementHelper.Create(project);
            }

            List<ProjectData> oldList = app.projectManagementHelper.GetProjectList();

            app.projectManagementHelper.Remove(0);

            List<ProjectData> newList = app.projectManagementHelper.GetProjectList();

            ProjectData toBeRemoved = oldList[0];
            oldList.RemoveAt(0);
            oldList.Sort();
            newList.Sort();

            Assert.AreEqual(oldList.Count, newList.Count);
            Assert.AreEqual(oldList, newList);

            Console.Write("---");
            Console.Out.Write(oldList.Count);
            Console.Write("---");
            Console.Out.Write(newList.Count);
            Console.Write("---");
        }
    }
}
