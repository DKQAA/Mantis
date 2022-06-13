using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace mantis_tests
{
    [TestFixture]
    public class ProjectCreationTests : ProjectManagementTestBase
    {
        [Test]
        public void ProjectCreationTest()
        {
            ProjectData project = new ProjectData()
            {
                Name = GenerateRandomLatinLetters(15),
                Description = GenerateRandomLatinLetters(15)
            };

            List<ProjectData> oldList = app.projectManagementHelper.GetProjectList();

            app.projectManagementHelper.Create(project);

            List<ProjectData> newList = app.projectManagementHelper.GetProjectList();

            oldList.Add(project);
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