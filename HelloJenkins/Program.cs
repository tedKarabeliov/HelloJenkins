namespace HelloJenkins
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static string CreateMessage()
        {
            return "Hello Jenkins!";
        }
    }
}
