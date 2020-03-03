using System;
using System.Collections.Generic;
using static System.Console;

namespace MyIteratorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> sequence = RandomNumberIterator(ChooseSequenceLength());

            do
            {
                WriteLine();
                Write(@"Here's your sequence: ");
                using (IEnumerator<int> cursor = sequence.GetEnumerator())
                {
                    while (cursor.MoveNext())
                    {
                        Write($"{cursor.Current} ");
                    }
                }

                WriteLine();

            } while (GetAnotherSequence());
        }

        static IEnumerable<int> RandomNumberIterator(int maxUses)
        {
            Random rand = new Random();
            for (int i = 0; i < maxUses; i++)
            {
                yield return rand.Next(101);
            }
        }

        static int ChooseSequenceLength()
        {
            int sequenceLength;
            WriteLine("Welcome to the Random Integer app.");
            WriteLine("With this app you can generate a sequence of integers between 1 and 100.");
            do
            {
                WriteLine("The length of the sequence can be between 1 and 30 integers.");
                Write("How long would you like the sequence(s) to be: ");
            } while (!int.TryParse(ReadLine(), out sequenceLength) || sequenceLength < 1 || sequenceLength > 30);

            return sequenceLength;
        }

        static bool GetAnotherSequence()
        {
            string answer;
            do
            {
                Write("Do you want another sequence? (Y or N): ");
                answer = ReadLine().ToUpper();
            } while (answer != "Y" && answer != "N");

            return answer is "Y";
        }
    }
}
