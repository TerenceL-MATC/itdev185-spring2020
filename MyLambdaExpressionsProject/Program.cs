using System;
using System.Collections.Generic;
using static System.Console;
using System.Threading;
using System.Text.RegularExpressions;
using System.Linq;

namespace MyLambdaExpressionsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = CreateList();  //Creates the list of words to use

            WriteLine("List has been finalized.");
            Write("Moving to main menu");
            Thread.Sleep(1000);
            Write('.');
            Thread.Sleep(1000);
            Write('.');
            Thread.Sleep(1000);
            Write('.');
            Thread.Sleep(1000);
            Clear();

            int choice;

            while(true)
            {
                choice = MenuOptions();

                if(choice is 6)
                {
                    break;
                }

                AppOperations(words, choice);
            }
        }

        //Controls the creation of a list of words
        static List<string> CreateList()
        {
            List<string> createdList = new List<string>();

            WriteLine("\nEnter a list of words below, one at the time, with letters only.");
            WriteLine("Hit the Enter key without typing anything signal that you done entering the list.");
            for(int i = 1; ; i++)
            {
                Write($"{i}: ");
                string wordToAdd = ReadLine().ToLower();

                while (wordToAdd.Length is 0 && i is 1) // Make sure user can't move on with an empty list
                {
                    WriteLine("Your list must have at least one word in it.");
                    Write("1: ");
                    wordToAdd = ReadLine().ToLower();
                }

                while (wordToAdd.Length != 0 && !Regex.IsMatch(wordToAdd, @"^[a-z]+$")) //Make sure user is entering words with letters only, if not done.
                {
                    WriteLine("You forgot that only letters were allowed.  Try it again!");
                    Write($"{i}: ");
                    wordToAdd = ReadLine().ToLower();
                }

                while (createdList.Contains(wordToAdd)) //Make sure words aren't repeated in list
                {
                    WriteLine("Sorry, that word is already on the list.");
                    Write($"{i}: ");
                    wordToAdd = ReadLine().ToLower();

                    while(!Regex.IsMatch(wordToAdd, @"^[a-z]+$")) //Make sure user is entering words with letters only
                    {
                        WriteLine("You forgot that only letters were allowed.  Try it again!");
                        Write($"{i}: ");
                        wordToAdd = ReadLine().ToLower();
                    }
                }

                if(wordToAdd.Length is 0) //User is finished entering words for the list
                {
                    break;
                }
                else //User has another word to add to the list
                {
                    createdList.Add(wordToAdd);
                }
            }

            return createdList; //The finished list of words
        }

        //Main menu after list is finalized
        static int MenuOptions()
        {
            int choice;
            WriteLine("\nWhat actions would you like to perform on this list?\n");
            WriteLine("1. Check if a word is in the list?");
            WriteLine("2. Get the n-th numbered word in the list.");
            WriteLine("3. Get all words that begin with a specified letter.");
            WriteLine("4. Display the list in a sorted order.");
            WriteLine("5. Get all words with a specified number of letters");
            WriteLine("6. Quit");
            Write("Enter your choice: ");

            while(!int.TryParse(ReadLine(), out choice) || choice < 1 || choice > 6) //Make sure valid choice is made
            {
                WriteLine(@"That option doesn't exist.  Try again!");
                Write("Enter your choice (1-6): ");
            }

            WriteLine();
            return choice; //The chosen option
        }

        //Controls the operations of the app when a choice from the main menu is made
        static void AppOperations(List<string> list, int choice)
        {
            switch(choice)
            {
                case 1: //See if a word is in the list
                    Write("What word would you like to find?: ");
                    string wordToFind = ReadLine().ToLower();

                    //Make sure that the word to find is in the proper format
                    while (wordToFind.Length is 0 || !Regex.IsMatch(wordToFind, @"^[a-z]+$")) 
                    {
                        WriteLine("You forgot that only letters were allowed.  Try it again!");
                        Write("What word would you like to find?: ");
                        wordToFind = ReadLine().ToLower();
                    }

                    int matchesFound = list.Count(word => word == wordToFind);

                    if(matchesFound is 0) //Word not found
                    {
                        WriteLine($"Sorry, the word, {wordToFind}, was not found.");
                    }
                    else //Word found
                    {
                        WriteLine($"Good news!  {wordToFind} is in the list.");
                    }
                    break;
                case 2: //Get the n-th numbered word from the list
                    string promptEnding = list.Count is 1 ? "1" : $"1-{list.Count}",
                           listLengthDesc = list.Count is 1 ? "1 word" : $"{list.Count} words";

                    Write(@$"What's the number of the word you would like to get? ({promptEnding}): ");

                    int wordPosition;
                    //Make sure the position chosen is a valid selection
                    while(!int.TryParse(ReadLine(), out wordPosition) || wordPosition < 1 || wordPosition > list.Count)
                    {
                        WriteLine(@$"There's only {listLengthDesc} in the list.");
                        Write(@$"What's the number of the word you would like to get? ({promptEnding}): ");
                    }

                    string askedForWord = list.First(word => word == list[wordPosition - 1]); //Gets the word at the chosen position

                    WriteLine($"The word at position {wordPosition} on the list is {askedForWord}."); //Outputs findings
                    break;
                case 3: //Get all words from the list that start with a specified letter
                    Write("You would like a list of all the words in the list beginning with?: ");
                    string letterHolder = ReadLine();
                    letterHolder = letterHolder != "" ? letterHolder.Trim().ToLower().Substring(0, 1) : null; //Takes first letter entered and clears buffer


                    //Makes sure that a letter was entered as a key for our search.
                    while(letterHolder is null || !Regex.IsMatch(letterHolder, @"^[a-z]+$"))
                    {
                        WriteLine("Please enter a letter to lookup.");
                        Write("You would like a list of all the words in the list beginning with?: ");
                        letterHolder = ReadLine().Trim().ToLower().Substring(0, 1);
                    }

                    char letterToLookup = letterHolder[0];

                    //Creates a IEnumerable object with all the words that begin with the user-specified letter.
                    IEnumerable<string> wordsThatBeginWith = list.Where(word => word[0] == letterToLookup);

                    if(wordsThatBeginWith.Count() is 0) //No words in the list start with the user-specified letter.
                    {
                        WriteLine(@$"Sorry, there aren't any words that begin with {letterToLookup}");
                    }
                    else //There's at least 1 word that starts with the user-specified letter.
                    {
                        WriteLine($"Here are the words that begin with {letterToLookup}:");
                        //Prints out all the words that start with the user-specified letter.
                        using (IEnumerator<string> cursor = wordsThatBeginWith.GetEnumerator())
                        {
                            while(cursor.MoveNext())
                            {
                                WriteLine(cursor.Current);
                            }
                        }
                    }
                    break;
                case 4: //Display the list in a specified sorted order
                    Sorting(list); //Sorting the list by order chosen by user.
                    break;
                case 5: //Display all words of a specified length
                    Write("How many letters are in the words you want to see: ");

                    int lettersInWords;
                    //Make sure value is at least 1, since a word needs to have at least 1 letter.
                    while(!int.TryParse(ReadLine(), out lettersInWords) || lettersInWords < 1)
                    {
                        WriteLine("Length specification must be at least 1 letter long.");
                        Write("How many letters are in the words you want to see: ");
                    }

                    //Creates a list of all the words that their length matches the user-specified length.
                    IEnumerable<string> nLetterWords = list.Where(word => word.Length == lettersInWords);

                    if(nLetterWords.Count() is 0) //No words match the user-specified length
                    {
                        WriteLine($@"Sorry, there aren't any {lettersInWords}-letter words in the list.");
                    }
                    else //There's at least 1 word's length that matches the user-specified length
                    {
                        WriteLine($@"Here are all the {lettersInWords}-letter words in the list.");
                        //Prints all the words that have a length that matches the user-specified length.
                        using (IEnumerator<string> cursor = nLetterWords.GetEnumerator())
                        {
                            while(cursor.MoveNext())
                            {
                                WriteLine(cursor.Current);
                            }
                        }
                    }
                    break;
            }

            WriteLine();
        }

        //Prompts the user to pick an order to sort the list by and performs the sort
        static void Sorting(List<string> list)
        {
            WriteLine("How would you like the list to be sorted?");
            WriteLine("1. From A to Z.");
            WriteLine("2. From Z to A.");
            WriteLine("3. In ascending word length");
            WriteLine("4. In descending word length");
            Write("Enter your choice: ");

            int sortChoice;
            //Make sure a vaild choice was selected
            while (!int.TryParse(ReadLine(), out sortChoice) || sortChoice < 1 || sortChoice > 4)
            {
                WriteLine(@"That option doesn't exist.  Please try again!");
                Write("Enter your choice (1-4): ");
            }

            IEnumerable<string> sortedList; //The sorted list of words

            //Sorts list based on the user's sort order selection.
            switch(sortChoice)
            {
                case 1: //From A to Z
                    sortedList = list.OrderBy(word => word);
                    WriteLine("Here is the list sorted from A to Z");
                    WriteLine("====================================");
                    break;
                case 2: //From Z to A
                    sortedList = list.OrderByDescending(word => word);
                    WriteLine("Here is the list sorted from Z to A");
                    WriteLine("====================================");
                    break;
                case 3: //In ascending word length
                    sortedList = list.OrderBy(word => word.Length);
                    WriteLine("Here is the list sorted by ascending word length");
                    WriteLine("=================================================");
                    break;
                default: //In descending word length
                    sortedList = list.OrderByDescending(word => word.Length);
                    WriteLine("Here is the list sorted by descending word length");
                    WriteLine("==================================================");
                    break;
            }

            //Prints out the sorted list.
            using(IEnumerator<string> cursor = sortedList.GetEnumerator())
            {
                while(cursor.MoveNext())
                {
                    WriteLine(cursor.Current);
                }
            }
        }
    }
}
