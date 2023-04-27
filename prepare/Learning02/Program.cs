using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.company = "Microsoft";
        job1.jobTitle = "Sotware Engineer";
        job1.startYear = 2012;
        job1.endYear = 2018;

        Job job2 = new Job();
        job2.company = "Micron";
        job2.jobTitle = "Web Developer";
        job2.startYear = 2018;
        job2.endYear = 2020;

        Resume myResume = new Resume();
        myResume.name = "Cindi Nichols";
        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();

    }
}