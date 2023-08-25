using SingletonPattern;

    class Program
    {
        static void Main(string[] args)
        {
            //Calling the GetInstance static method to get the Singleton Instance
            //Return_type is SingleTon(Instance)
            Singleton fromClient = Singleton.GetInstance();
            //Using One Instance performing Multiple Tasks

            fromClient.ClientDetails("C101","Client-1");
            Console.WriteLine("Addition : " + fromClient.Addition(55, 24));//Calling Addition Method

            Singleton fromClient2 = Singleton.GetInstance();//Existed Instance
            fromClient2.ClientDetails("C102","Client-2");
            Console.WriteLine("Addition : "+fromClient2.Addition(67, 10));//Calling Addition Method

            fromClient2.ClientDetails("C103","Client-3");
            Console.WriteLine("Addition : " + fromClient2.Addition(98, 23));//Calling Addition Method

            Console.ReadKey();
    }
}
