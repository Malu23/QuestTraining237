using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Index
{
    internal class Program
    {
        // class ShoppingList
        // {
        //     private string[] _items = new string[10];
        //     public string this[int index]
        //     {
        //         get => _items[index];
        //         set { _items[index] = value; }
        //     }

        //     public int TotalItems => _items.Count(i => i != null);
        // }

        class ShoppingList
        {
            private List<string> _items = new List<string>();

            public string this[int index]
            {
                get 
                {
                    if(index >= _items.Count)
                    {
                        throw new IndexOutOfRangeException("Index out of range.");
                    }
                    return _items[index];
                }
                set
                {
                    if (index >= _items.Count)
                    {
                        _items.Add(value); 
                    }
                    else
                    {
                        _items[index] = value;
                    }
                }
            }

            public int TotalItems => _items.Count;
        }

        // static void Main(string[] args)
        // {
        //     var lst = new ShoppingList();
        //     lst[0] = "apple";
        //     lst[1] = "banana";

        //     System.Console.WriteLine(lst.TotalItems);
        // }

        static void Main(string[] args)
        {
            var lst = new ShoppingList();
            lst[0] = "apple";
            lst[1] = "banana";
            lst[2] = "orange";

            Console.WriteLine($"Total items in shopping list: {lst.TotalItems}");

            for (int i = 0; i < lst.TotalItems; i++)
            {
                Console.WriteLine(lst[i]);
            }
        }
    }
}


 
        

        
    
