using System;

public class Generations
{
    public void MovementOfObjects() //Tracking the movements of Objects between Generations
    {
        int objectCountGen1 = 0, objectCountGen2 = 0;
        Generations generations = new Generations();

        DateTime startTimeGen0 = DateTime.Now;  //Time Starts when objects created in Gen0

        while (GC.GetGeneration(generations) == 0)  //loops runs until objects moved to Gen1
        {
            Generations generations1 = new Generations();//creating objects

            objectCountGen1++;  //Counting of Objects in Gen1
        }//end of while loop

        DateTime endTimeGen1 = DateTime.Now;    //Time ends when objects moved to Gen1

        TimeSpan timeSpanGen1 = endTimeGen1 - startTimeGen0;    //calculating time of objects (Gen0 - Gen1) 
        Console.WriteLine("Objects in Generation: " + GC.GetGeneration(generations));   //Location of Objects
        Console.WriteLine("Time Taken for objects to move from Gen0 to Gen1 in ms :" + timeSpanGen1.TotalMilliseconds + " ms");
        Console.WriteLine("Total objects :" + objectCountGen1); //total count of Objects

        DateTime startTimeGen1 = DateTime.Now;  //Time Starts when objects moved to Gen1

        while (GC.GetGeneration(generations) == 1)  //loops runs until objects moved to Gen2
        {
            Generations generations1 = new Generations();//creating objects
            Generations generations2 = new Generations();

            objectCountGen2++;  //Counting of Objects in Gen2
        }//end of while loop

        DateTime endTimeGen2 = DateTime.Now;    //Time ends when objects moved to Gen2

        TimeSpan timeSpanGen2 = endTimeGen2 - startTimeGen1;    //calculating time of objects (Gen1 - Gen2) 
        Console.WriteLine("Objects in Generation: " + GC.GetGeneration(generations));   //Location of Objects
        Console.WriteLine("Time Taken for objects to move from Gen1 to Gen2 in ms :" + timeSpanGen2.TotalMilliseconds + " ms");
        Console.WriteLine("Total objects :" + objectCountGen2); //total count of Objects
    }
}