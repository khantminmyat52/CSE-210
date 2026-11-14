using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Create a class job1
        Job job1 = new Job();
        // Set the value to the member 
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create a second class job2
        Job job2 = new Job();
        // Set the value to the member 
        job2._jobTitle = "Manger";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create an instance
        Resume resume = new Resume();
        resume._name = "Khant Min Myat";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayMyResume();
    }
}