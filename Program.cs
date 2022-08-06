﻿using System;
using Library;

namespace Libary
{
    internal class Program
    {
        static List<Item> items;
         static void Main(string[] args)
        {
            int choice;
            Item newItem;
            bool works;

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
                         newItem = new Item();
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
    }
}