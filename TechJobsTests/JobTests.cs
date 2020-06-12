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
            PositionType testPositionType = new PositionType("Quality contorl");
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
            PositionType testPositionType = new PositionType("Quality contorl");
            CoreCompetency testCoreCopetency = new CoreCompetency("Persistence");

            Job testJob5 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);
            Job testJob6 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);

            Assert.IsFalse(testJob5.Equals(testJob6));
        }
    }
}
