class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Cook";
        job1._company = "Denny's";
        job1._startYear = 2023;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Emergency Operator";
        job2._company = "Avant Guard";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}