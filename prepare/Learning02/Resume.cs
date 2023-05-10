public class Resume
{
    public List<Job> _jobs = new List<Job>();
    public String _name;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}