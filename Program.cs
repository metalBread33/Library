using System;
using Library;

namespace Libary
{
    internal class Program
    {
        List<Item> items;
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to Library Program");

            do
            {
                Console.WriteLine("Please select a menu option");
                Console.WriteLine("1) Add a new item\n2) Remove an item\n3) Edit an item");
                choice = int.Parse(Console.ReadLine());
            }
            while (choice != 0);
            
        }

        void addItem (Item newItem)
        {
            items.Add(newItem);
        }

        void removeItem (int position)
        {
            items.RemoveAt(position);
        }

        void editItem (int position, Item newItem)
        {
            items.RemoveAt (position);
            items.Insert(position, newItem);
        }
    }
}