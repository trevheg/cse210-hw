using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Cisco";
        job1._startYear = 2005;
        job1._endYear = 2012;
        // job1.DisplayJobDetails();

        Job job2 = new Job(); 
        job2._jobTitle = "Project Manager";
        job2._companyName = "NVidia";
        job2._startYear = 2012;
        job2._endYear = 2018;
        // job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "John Smith";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.DisplayResume();

    }
}