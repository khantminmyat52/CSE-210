using System.Runtime.CompilerServices;

public class Resume
{
    // Create the member of this class
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Create a method of this class which has no return
    public void DisplayMyResume()
    {
        Console.WriteLine($"Name : {_name}");
        Console.WriteLine($"Jobs : ");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}

