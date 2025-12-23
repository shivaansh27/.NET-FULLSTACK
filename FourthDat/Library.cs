using System;
using System.Collections.Generic;
using System.Linq;
class Library
{
    private Dictionary<int, string> Books = new Dictionary<int, string>();
    public string this[int bookId]
    {
        get
        {
            return Books[bookId];
        }
        set
        {
            Books[bookId] = value;
        }
    }

    public string this[string title]
    {
        get
        {
            return Books.FirstOrDefault(e=>e.Value == title).Value;
        }
    }
}