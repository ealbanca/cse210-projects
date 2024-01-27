using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Data Analist";
        job1._company = "Google";
        job1._startYear = 2010;
        job1._endYear = 2015;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Team Manager";
        job2._company = "Facebook";
        job2._startYear = 2016;
        job2._endYear = 2023;
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Hared Albancando Robles";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
        
    }

}