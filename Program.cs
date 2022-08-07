﻿using System;
using Library;

namespace Libary
{
    internal class Program
    {
        static List<Item> items = new List<Item>();
         static void Main(string[] args)
        {
            int choice, numItems = 0;
            char fin;

            Console.WriteLine("Welcome to Library Program");

            do
                {
                int position;

                Console.WriteLine("Please select a menu option");
                Console.WriteLine("1) Add a new item\n2) Remove an item" +
                    "\n3) Edit an item\n4) Print list\n0) Quit");
              bool ok = int.TryParse(Console.ReadLine(), out choice);
                Item newItem = new Item();
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
                        newItem.title = Console.ReadLine();

                        Console.WriteLine("Please enter the author's name");
                        newItem.author = Console.ReadLine();

                        Console.WriteLine("What genre is it (enter f for fantasy, " 
                            + "s for sci-fi, t for thriller/horror," +
                            " or n for non-fiction ");
                         char.TryParse(Console.ReadLine(), out newItem.genre);

                        Console.WriteLine("Have you finished this title yet? " +
                            "(type 'y/Y' for yes or 'n/N' for no)");
                        char.TryParse(Console.ReadLine(), out fin);
                        if (validOption(fin) && char.ToUpper(fin) == 'Y')
                            newItem.isFinished = true;
                        else newItem.isFinished = false;
                        
                        numItems++;
                        addItem(newItem);
                      
                        break;

                    case 2:
                        Console.WriteLine("Which entry would you like to remove?");
                        printList();

                        int.TryParse(Console.ReadLine(), out position);
                        if (position >= numItems || position < 0)
                            removeItem(position); 
                        else
                            Console.WriteLine("Please try again and enter a valid entry");
                        break;


                    case 3:
                        
                        Console.WriteLine("Which item would you like to edit?");
                        printList();

                        int.TryParse(Console.ReadLine(), out position);
                        editItem(position);
                        break;
                   
                    case 4:
                        printList();
                        break;

                    default:
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
            items.RemoveAt(position-1);
        }

        static void editItem(int position)
        {
            Item itemEdit = items[position - 1];
            int editWhat; char fin;
            do
                {
                    Console.WriteLine("What details would you like to change?");
                    Console.WriteLine("1) Title: " + itemEdit.title);
                    Console.WriteLine("2) Author: " + itemEdit.author);
                    Console.WriteLine("3) Genre: " + itemEdit.genre);
                    Console.WriteLine("4) Completed: " + itemEdit.isFinished);
                    Console.WriteLine("0) Finished");
                    int.TryParse(Console.ReadLine(), out editWhat);

                    switch (editWhat)
                    {
                        case 1:
                            Console.WriteLine("What is the new title?");
                            itemEdit.title = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("Who is the new author?");
                            itemEdit.author = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("What is the new genre?(enter f for fantasy, " 
                            + "s for sci-fi, t for thriller/horror," +
                            " or n for non-fiction ");
                            char.TryParse(Console.ReadLine(), out itemEdit.genre);

                        break;

                        case 4:
                            Console.WriteLine("Have you finished this book? " +
                                "(type 'y/Y' for yes or 'n/N' for no)");
                            char.TryParse(Console.ReadLine(), out fin);
                            if (validOption(fin) && char.ToUpper(fin) == 'Y')
                                itemEdit.isFinished = true;
                            else itemEdit.isFinished = false;
                        break;

                        default:
                            break;
                    }


                } while (editWhat != 0);
            }

        static void printList ()
        {
            for (int i = 0; i < items.Count; i++)
                Console.WriteLine(i+1 + " " + items[i].ToString());
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