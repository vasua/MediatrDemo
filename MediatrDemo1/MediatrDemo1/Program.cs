using System;
using System.Collections.Generic;

namespace MediatrDemo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Application application = new Application();
            Console.WriteLine("Let's add new security:");
            Console.ReadKey();
            var createdSecurity = application.CreateSecurity("Bond", "Wells", 80);
            Console.WriteLine($"Our security has: Id - {createdSecurity.Id}; Name - {createdSecurity.Name}; Issue Price - {createdSecurity.IssuePrice}");
            var fetchedSecurity = application.GetSecurity("Bond");

        }

    }

}
