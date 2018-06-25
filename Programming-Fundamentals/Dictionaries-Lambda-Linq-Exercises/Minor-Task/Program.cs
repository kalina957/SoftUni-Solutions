using System;
using System.Collections.Generic;

namespace Minor_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dict= new Dictionary<string,int>();

            while (true)
            {
                var input1 = Console.ReadLine();
                if (input1 == "stop") break;
                var input2 = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(input1)) dict[input1] += input2;
                else dict.Add(input1,input2);
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key +" -> "+item.Value);
            }
        }
    }
}
