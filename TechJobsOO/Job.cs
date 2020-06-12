using System;
using System.Net.Http;

namespace TechJobsOO
{
    public class Job 
    {
        public int Id { get; }
        private static int nextId = 1;
        private string Value;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public Job(string value)
        {
            this.Value = value;
        }

        //TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {
            string notAvailable = "Data not available";
            string message;
            
            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)
            {
                message = "OOPS! This job does not seem to exist.";
            }
            else
            {
                 message = "\n" + 
                    $"ID: {Id}\n" + $"Name: {(String.IsNullOrEmpty(Name.ToString()) ? notAvailable : Name.ToString())}\n" + 
                    $"Employer: {(String.IsNullOrEmpty(EmployerName.ToString()) ? notAvailable : EmployerName.ToString())}\n" + 
                    $"Location: {(String.IsNullOrEmpty(EmployerLocation.ToString()) ? notAvailable : EmployerLocation.ToString())}\n" + 
                    $"Position Type: {(String.IsNullOrEmpty(JobType.ToString()) ? notAvailable : JobType.ToString())}\n" + 
                    $"Core Competency: {(String.IsNullOrEmpty(JobCoreCompetency.ToString()) ? notAvailable : JobCoreCompetency.ToString())}\n" + 
                    "\n";
            }
            return message;
        }

    }
}
