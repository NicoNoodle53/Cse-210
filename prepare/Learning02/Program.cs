using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        //initialize job1 and assign variables
        Job Job1 = new Job();
        Job1._company = "Apple";
        Job1._jobTitle = "Manager";
        Job1._startYear = 2021;
        Job1._endYear = 2023;

        //initialize job2 and assign variables
        Job Job2 = new Job();
        Job2._company = "Amazon";
        Job2._jobTitle = "Software Engineer";
        Job2._startYear = 2023;
        Job2._endYear = 2025;


        //initialize Resume for Nicholas and assign variables
        Resume myResume = new Resume();
        myResume._name = "Nicholas";
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

        //display info
        myResume.Display();
    }
}