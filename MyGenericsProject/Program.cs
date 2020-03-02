using System;
using static System.Console;

namespace MyGenericsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, 
                dataType = ListElementTypeChoice();

            GenericLinkedList<int> intList = new GenericLinkedList<int>();
            GenericLinkedList<double> doubleList = new GenericLinkedList<double>();
            GenericLinkedList<string> stringList = new GenericLinkedList<string>();

            switch(dataType)
            {
                case 1:
                    intList.CreateList();
                    break;
                case 2:
                    doubleList.CreateList();
                    break;
                case 3:
                    stringList.CreateList();
                    break;
            }

            while(true)
            {
                choice = GetMenuChoice();

                if(choice is 12)
                {
                    return;
                }

                switch(dataType)
                {
                    case 1:
                        AppOperations(intList, choice);
                        break;
                    case 2:
                        AppOperations(doubleList, choice);
                        break;
                    case 3:
                        AppOperations(stringList, choice);
                        break;
                }

                WriteLine();
            }

        }

        static int ListElementTypeChoice()
        {
            int choice;
            WriteLine("What data type will you like to use for your list?");
            WriteLine("1. int");
            WriteLine("2. double");
            WriteLine("3. string");
            Write("Your choice: ");

            while(!int.TryParse(ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                WriteLine("Choice must be 1, 2, or 3.");
                Write("Your choice (1-3): ");
            }

            return choice;
        }

        static int GetMenuChoice()
        {
            int choice;
            WriteLine("1. Display List");
            WriteLine("2. Insert in empty list/insert in beginning");
            WriteLine("3. Insert a node at the end of the list"); ;
            WriteLine("4. Insert a node at a given position");
            WriteLine("5. Delete first node");
            WriteLine("6. Delete last node");
            WriteLine("7. Delete a node at a given position");
            WriteLine("8. Reverse the list");
            WriteLine("9. Insert cycle");
            WriteLine("10. Detect cycle");
            WriteLine("11. Remove cycle");
            WriteLine("12. Quit");
            WriteLine();
            Write("What would you like to do?: ");
            while (!int.TryParse(ReadLine(), out choice) || choice < 1 || choice > 12)
            {
                WriteLine("Invaild choice!  Must be between 1 to 12.");
                Write("What would you like to do?: ");
            }

            return choice;
        }

        static void AppOperations<T>(GenericLinkedList<T> aList, int choice)
        {
            int position;
            T data;
            object holder = null;

            switch (choice)
            {
                case 1:
                    aList.Display();
                    break;
                case 2:
                    Write("Enter the value of the node to be inserted: ");
                    do
                    {
                        try
                        {
                            holder = Convert.ChangeType(ReadLine(), typeof(T));
                        }
                        catch (Exception)
                        {
                            WriteLine($"Value entered must be {typeof(T).Name}.\n");
                            Write("Enter the value of the node to be inserted: ");
                        }
                    } while (holder is null);
                    
                    data = (T)holder;
                    aList.InsertAtBeginning(data);
                    break;
                case 3:
                    Write("Enter the value of the node to be inserted: ");
                    do
                    {
                        try
                        {
                            holder = Convert.ChangeType(ReadLine(), typeof(T));
                        }
                        catch (Exception)
                        {
                            WriteLine($"Value entered must be {typeof(T).Name}.\n");
                            Write("Enter the value of the node to be inserted: ");
                        }
                    } while (holder is null);

                    data = (T)holder;
                    aList.InsertAtEnd(data);
                    break;
                case 4:
                    Write("Enter the value of the node to be inserted: ");
                    do
                    {
                        try
                        {
                            holder = Convert.ChangeType(ReadLine(), typeof(T));
                        }
                        catch (Exception)
                        {
                            WriteLine($"Value entered must be {typeof(T).Name}.\n");
                            Write("Enter the value of the node to be inserted: ");
                        }
                    } while (holder is null);

                    data = (T)holder;

                    Write("Enter the position where the node is to be inserted at: ");
                    while (!int.TryParse(ReadLine(), out position))
                    {
                        WriteLine("Value entered must be an integer.\n");
                        Write("Enter the position where the node is to be inserted at: ");
                    }

                    aList.InsertAtPosition(data, position);
                    break;
                case 5:
                    try
                    {
                        data = aList.DeleteFirstNode();
                        WriteLine($"Value of the node deleted was {data}.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        WriteLine(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        data = aList.DeleteLastNode();
                        WriteLine($"Value of the node deleted was {data}.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        WriteLine(ex.Message);
                    }
                    break;
                case 7:
                    try
                    {
                        Write("Enter the position where the node to be deleted is at: ");
                        while (!int.TryParse(ReadLine(), out position))
                        {
                            WriteLine("Value entered must be an integer.\n");
                            Write("Enter the position where the node to be deleted is at: ");
                        }

                        data = aList.DeleteNodeAtPosition(position);
                        WriteLine($"Value of the node deleted was {data}.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        WriteLine(ex.Message);
                    }
                    break;
                case 8:
                    aList.ReverseList();
                    break;
                case 9:
                    Write("Enter the value where a cycle should be inserted: ");

                    do
                    {
                        try
                        {
                            holder = Convert.ChangeType(ReadLine(), typeof(T));
                        }
                        catch (Exception)
                        {
                            WriteLine($"Value entered must be {typeof(T).Name}.\n");
                            Write("Enter the value of the node to be inserted: ");
                        }
                    } while (holder is null);

                    data = (T)holder;
                    aList.InsertCycle(data);
                    break;
                case 10:
                    if (aList.HasCycle())
                    {
                        WriteLine("The current list has a cycle.\n");
                    }
                    else
                    {
                        WriteLine("The current list doesn\'t have a cycle.\n");
                    }
                    break;
                case 11:
                    aList.RemoveCycle();
                    break;
            }

            WriteLine();
        }
    }
}
