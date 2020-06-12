using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            Assert.AreEqual(testJob1.Id + 1, testJob2.Id);

            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPositionType = new PositionType("Quality control");
            CoreCompetency testCoreCopetency = new CoreCompetency("Persistence");

            Job testJob3 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);
            Job testJob4 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);

            Assert.AreEqual(testJob3.Name, testJob4.Name);
            Assert.AreEqual(testJob3.EmployerName, testJob4.EmployerName);
            Assert.AreEqual(testJob3.EmployerLocation, testJob4.EmployerLocation);
            Assert.AreEqual(testJob3.JobType, testJob4.JobType);
            Assert.AreEqual(testJob3.JobCoreCompetency, testJob4.JobCoreCompetency);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPositionType = new PositionType("Quality control");
            CoreCompetency testCoreCopetency = new CoreCompetency("Persistence");

            Job testJob5 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);
            Job testJob6 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);

            Assert.IsFalse(testJob5.Equals(testJob6));
        }
        [TestMethod]
        public void TestJobsToString()
        {
            Employer testEmployer = new Employer("ACME");
            Location testLocation = new Location("Desert");
            PositionType testPositionType = new PositionType("Quality control");
            CoreCompetency testCoreCopetency = new CoreCompetency("Persistence");

            Job testJob7 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);
            Job testJob8 = new Job("Product tester", new Employer(), new Location(), testPositionType, testCoreCopetency);
            Job testJob9 = new Job();

            Assert.AreEqual(testJob7.ToString(), "\n" + "ID: 5\n" + "Name: Product tester\n" + "Employer: ACME\n" + "Location: Desert\n" + "Position Type: Quality control\n" + "Core Competency: Persistence\n" + "\n");

            Assert.AreEqual(testJob8.ToString(), "\n" + "ID: 6\n" + "Name: Product tester\n" + "Employer: Data not available\n" + "Location: Data not available\n" + "Position Type: Quality control\n" + "Core Competency: Persistence\n" + "\n");

            Assert.AreEqual(testJob9.ToString(), "OOPS! This job does not seem to exist.");


        }
    }
}
