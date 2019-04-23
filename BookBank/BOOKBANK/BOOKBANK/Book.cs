using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKBANK
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Edition;
        public long ISBN;
        public double Price;
        private string ImagePath;

        public Book(string title, string author, string ed, string imgpath, long isbn, double price)
        {//initialize the class variables
            Title = title;
            Author = author;
            Edition = ed;
            ImagePath = imgpath;
            ISBN = isbn;
            Price = price;
        }
        ///Returns the image of the book cover after reading it from file

        public Bitmap Image
        {
            get { return new Bitmap(ImagePath); }
        }

    }
}
