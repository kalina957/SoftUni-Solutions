using System;
using System.Collections.Generic;

namespace Problem_5._Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long currNum = long.Parse(Console.ReadLine());
            Queue<long> numbers = new Queue<long>();
            Queue<long> sequence = new Queue<long>();
            numbers.Enqueue(currNum);

            while (numbers.Count<50)
            {
                numbers.Enqueue(currNum + 1);
                sequence.Enqueue(currNum + 1);

                if (numbers.Count < 50)
                {
                    numbers.Enqueue(2 * currNum + 1);
                    sequence.Enqueue(2 * currNum + 1);
                }

                if (numbers.Count < 50)
                {
                    numbers.Enqueue(currNum + 2);
                    sequence.Enqueue(currNum + 2);
                    currNum = sequence.Dequeue();
                }
            }
           
                Console.Write(string.Join(" ",numbers));
            
        }
    }
}
