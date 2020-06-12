using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        public static Employer testEmployer = new Employer("ACME");
        public static Employer emptyEmployer = new Employer("");
        public static Location testLocation = new Location("Desert");
        public static Location emptyLocation = new Location("");
        public static PositionType testPositionType = new PositionType("Quality control");
        public static CoreCompetency testCoreCopetency = new CoreCompetency("Persistence");

        Job testJob1 = new Job();
        Job testJob2 = new Job();
        Job testJob3 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);
        Job testJob4 = new Job("Product tester", testEmployer, testLocation, testPositionType, testCoreCopetency);
        Job testJob5 = new Job("Product tester", emptyEmployer, emptyLocation, testPositionType, testCoreCopetency);

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(testJob1.Id + 1, testJob2.Id);
            Assert.IsFalse(testJob1.Equals(testJob2));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(testJob3.Name, testJob4.Name);
            Assert.AreEqual(testJob3.EmployerName, testJob4.EmployerName);
            Assert.AreEqual(testJob3.EmployerLocation, testJob4.EmployerLocation);
            Assert.AreEqual(testJob3.JobType, testJob4.JobType);
            Assert.AreEqual(testJob3.JobCoreCompetency, testJob4.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(testJob3.Equals(testJob4));
        }

        [TestMethod]
        public void TestJobsToString()
        {
            Assert.AreEqual(testJob3.ToString(), "\n" + 
                "ID: 13\n" + 
                "Name: Product tester\n" + 
                "Employer: ACME\n" + 
                "Location: Desert\n" + 
                "Position Type: Quality control\n" + 
                "Core Competency: Persistence\n" + 
                "\n");

            Assert.AreEqual(testJob5.ToString(), "\n" + 
                "ID: 15\n" + 
                "Name: Product tester\n" + 
                "Employer: Data not available\n" + 
                "Location: Data not available\n" + 
                "Position Type: Quality control\n" + 
                "Core Competency: Persistence\n" + 
                "\n");

            Assert.AreEqual(testJob1.ToString(), "OOPS! This job does not seem to exist.");
        }
    }
}
