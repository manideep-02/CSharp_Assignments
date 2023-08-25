using System;

namespace SingletonPattern
{
    public sealed class Singleton
    // We used sealed class to restrict the inheritance
    {
        //This static variable value will be increment by 1 each time the object of the class is created
        private static int count = 0;

        //This static variable is going to store the Singleton Instance
        private static Singleton instance = null;

        //The following Static Method is going to create the instance and return the Singleton Instance
        public static Singleton GetInstance()
        { 
            /* If the variable instance is null, then create the Singleton instance 
               else return the already created singleton instance
               This version is not thread-safe */
            if (instance == null)
            {
                instance = new Singleton();//Creating new Instance
            }

            //Return the Singleton Instance
            return instance;
        }

        /*  Constructor is Private means, from outside the class we cannot create an instance of this class
            But within the class, we can create an instance */
        private Singleton() 
        {
            //Each Time the Constructor is called When Object is created and increment the Counter value by 1
            count++;
            Console.WriteLine("Number of Objects Created : " + count);
        }

        //The following Methods can be accessed from outside of the class by using the Singleton Instance
        
        //ClientDetails Methods records the Client Details
        public void ClientDetails(string clientId,string clientName)
        {
            Console.WriteLine("Id : "+clientId);
            Console.WriteLine("Name : "+clientName);
        }

        //Addition Methods Performs Adding of two values and returns sum of two values
        public int Addition(int sum1, int sum2) 
        {
            return sum1 + sum2;
        }
    }
}
