public class Job
{
    // Cerate a member or attribute of this class
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Create a method of this class which will display the member values
    public void DisplayJobDetails() //This method will just the display the message and do not have any return
    {
        Console.WriteLine($"{_jobTitle} | ({_company}) | {_startYear}-{_endYear}");
    }
}