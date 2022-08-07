using System;
using Library;

namespace Libary
{
    internal class Program
    {
        static List<Item> items;
         static void Main(string[] args)
        {
            int choice, pageCount;
            Item newItem;
            bool works, finished;
            string title, author;
            char genre, fin;

            Console.WriteLine("Welcome to Library Program");

            do
            {
                Console.WriteLine("Please select a menu option");
                Console.WriteLine("1) Add a new item\n2) Remove an item" +
                    "\n3) Edit an item\n4) Print list\n0) Quit");
              bool ok = int.TryParse(Console.ReadLine(), out choice);

                while (!validOption(choice) || !ok)
                {
                    Console.WriteLine("Please enter a valid menu option " +
                        "(must be between 0 and 4");
                    Console.WriteLine("1) Add a new item\n2) Remove an item" +
                   "\n3) Edit an item\n4) Print list\n0) Quit");
                    ok = int.TryParse(Console.ReadLine(), out choice);
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter a title");
                        title = Console.ReadLine();

                        Console.WriteLine("Please enter the author's name");
                        author = Console.ReadLine();

                        Console.WriteLine("What genre is it (enter f for fantasy, " 
                            + "s for sci-fi, t for thriller/horror," +
                            " or n for non-fiction ");
                        char.TryParse(Console.ReadLine(), out genre);

                        Console.WriteLine("Have you finished this title yet? " +
                            "(type 'y/Y' for yes or 'n/N' for no");
                        char.TryParse(Console.ReadLine(), out fin);
                        if (validOption(fin) && char.ToUpper(fin) == 'Y')
                            finished = true;
                        else finished = false;


                        newItem = new Item(title, author, genre, finished);
                        addItem(newItem);
                      
                        break;
                    case 2:
                        int position;
                        works = int.TryParse(Console.ReadLine(), out position);
                        removeItem(position);
                        break;
                    case 3:
                        newItem = new Item();
                        works = int.TryParse(Console.ReadLine(), out position);
                        editItem(position, newItem);
                        break;
                    case 4:
                        printList();
                        break;
                }
                    
            }
            while (choice != 0);
            
        }

         static void addItem (Item newItem)
        {
            items.Add(newItem);
        }

        static void removeItem (int position)
        {
            items.RemoveAt(position);
        }

        static void editItem (int position, Item newItem)
        {
            items.RemoveAt (position);
            items.Insert(position, newItem);
        }

        static void printList ()
        {
            foreach (var item in items)
                Console.WriteLine(item.ToString());
        }

       static bool validOption (int choice)
        {
            if (choice < 0 || choice > 4)
                return false;
            else return true;
        }

        static bool validOption (char c)
        {
            if (c == 'y' || c == 'n')
                return true;
            else if (c=='Y' || c=='N')
                return true;
            else return false;
        }
    }
}