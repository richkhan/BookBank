using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BOOKBANK
{
    public partial class frmBookBank : Form
    {
        /***************************************************************************
         < project firstname="Richard" lastname="Sunmonu" projectname="Book Bank"/>
        ***************************************************************************/

        /// <summary>
        /// This project maintains a database of books.
        /// 1.Book info is read from a csv file
        /// 2.The user is shown a list of books that 
        /// 3.when clicked shows title, author, edition, isbn, price, anda book image 
        /// </summary>

        public List<Book> bookBank = new List<Book>();
        
        /*
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
        */

        public frmBookBank()
        {
            InitializeComponent();
        }

        private void frmBookBank_Load(object sender, EventArgs e)
        {

        }

        private void btnUploadCSV_Click(object sender, EventArgs e)
        {
            lvData.Items.Clear();
            string[] lines;


            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "CSV Files|*.csv";
            fd.ShowDialog();

            lines = File.ReadAllLines(fd.FileName);
            double lowPrice = 0;
            double highPrice = 0;
            double avgPrice = 0;

            
            for (int i = 1; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(',');

                Book tempBook = new Book(words[0], words[1], words[2], words[3], Convert.ToInt64(words[4]), Convert.ToDouble(words[5]));
                bookBank.Add(tempBook);



                //String[] row1 = {words[1], words[2], words[4], words[5] };

                //adds row to the ListView grid
                //lvData.Items.Add(words[0]).SubItems.AddRange(row1);
                lvData.Items.Add(words[0]);

                int totalNumBooks = lines.Length - 1;
                lblTotalBookNum.Text = (totalNumBooks.ToString());

                
                if (i == 1)
                {
                    lowPrice = tempBook.Price;
                    highPrice = tempBook.Price;
                }
                else
                {
                    if(tempBook.Price < lowPrice)
                    {
                        lowPrice = tempBook.Price;
                    }
                    if(tempBook.Price > highPrice)
                    {
                        highPrice = tempBook.Price;
                    }
                }

                avgPrice += tempBook.Price;

                
            }
            avgPrice = avgPrice / bookBank.Count();

            //outputs the data
            lblAvgBook.Text = "$" + avgPrice.ToString();
            lblLowBook.Text = "$" + lowPrice.ToString();
            lblHighBook.Text = "$" + highPrice.ToString();
   
        }


        private void lvData_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                Book tempbk = bookBank[lvData.FocusedItem.Index];
                lblTitle.Text = tempbk.Title;
                lblAuthor.Text = tempbk.Author;
                lblEdition.Text = tempbk.Edition + " Ed.";
                lblISBN.Text = "ISBN: " + tempbk.ISBN.ToString();
                lblPrice.Text = "$" + tempbk.Price.ToString();
                imgBookCover.Image = tempbk.Image;

                //MessageBox.Show(lvData.FocusedItem.Index.ToString());
                //lvData.SelectedIndices.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            this.Hide(); //Hide Main form
            f.ShowDialog();
            this.Show(); //show main form
        }

        private void btnFindIsbn_Click(object sender, EventArgs e)
        {
            /*
            frmLookUpISBN f = new frmLookUpISBN();
            //this.Hide(); //Hide Main form
            f.ShowDialog();
            this.Show(); //show main form
            */

            /*
            if (txtSearchISBN.Text == tempBook.ISBN.ToString())
            {
                MessageBox.Show("Awesome!");
            }
            */
            long result;
            if (long.TryParse(txtSearchISBN.Text, out result) == true)
            {
                //long temp; 
                //long lg = long.TryParse(txtSearchISBN.Text, out temp);

                for (int i = 0; i < bookBank.Count; i++)
                {
                    if (bookBank[i].ISBN == result)
                    {
                        //MessageBox.Show("");
                        lblTitle.Text = bookBank[i].Title;
                        lblAuthor.Text = bookBank[i].Author;
                        lblEdition.Text = bookBank[i].Edition + " Ed.";
                        lblISBN.Text = "ISBN: " + bookBank[i].ISBN.ToString();
                        lblPrice.Text = "$" + bookBank[i].Price.ToString();
                        imgBookCover.Image = bookBank[i].Image;
                        return;
                    }

                }
                MessageBox.Show("Book Not found");
            }
            else
                MessageBox.Show("Invalid Entry");
            
        }
    }
}
