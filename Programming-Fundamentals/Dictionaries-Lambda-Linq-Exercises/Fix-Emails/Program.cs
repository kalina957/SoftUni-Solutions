using System;
using System.Collections.Generic;
using System.Linq;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
             Dictionary<string, string> data = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while (name!="stop")
                {
                string email = Console.ReadLine();
                string ending = email.Substring(email.Length - 2, 2);
                if (ending!="uk"&&ending!="us") data.Add(name,email);
                 name = Console.ReadLine();
            }
            foreach (var item in data) Console.WriteLine(item.Key+" -> "+item.Value);
            
        }
    }
}
