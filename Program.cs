using System;
using Library;

namespace Libary
{
    internal class Program
    {
        List<Item> items;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Library Program");
            
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