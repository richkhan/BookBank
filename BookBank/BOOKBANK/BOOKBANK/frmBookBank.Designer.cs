namespace BOOKBANK
{
    partial class frmBookBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader colTitle;
            this.btnUploadCSV = new System.Windows.Forms.Button();
            this.imgBookCover = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalBookNum = new System.Windows.Forms.Label();
            this.lvData = new System.Windows.Forms.ListView();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFindIsbn = new System.Windows.Forms.Button();
            this.lblLowBook = new System.Windows.Forms.Label();
            this.lblLeastExpnBook = new System.Windows.Forms.Label();
            this.lblHighBook = new System.Windows.Forms.Label();
            this.lblMostExpnBook = new System.Windows.Forms.Label();
            this.lblAvgBook = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchISBN = new System.Windows.Forms.TextBox();
            this.grpLookUpISBN = new System.Windows.Forms.GroupBox();
            this.grpBookStats = new System.Windows.Forms.GroupBox();
            colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.imgBookCover)).BeginInit();
            this.grpLookUpISBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // colTitle
            // 
            colTitle.Text = "Title";
            colTitle.Width = 375;
            // 
            // btnUploadCSV
            // 
            this.btnUploadCSV.Location = new System.Drawing.Point(636, 542);
            this.btnUploadCSV.Name = "btnUploadCSV";
            this.btnUploadCSV.Size = new System.Drawing.Size(125, 62);
            this.btnUploadCSV.TabIndex = 0;
            this.btnUploadCSV.Text = "Upload CSV";
            this.btnUploadCSV.UseVisualStyleBackColor = true;
            this.btnUploadCSV.Click += new System.EventHandler(this.btnUploadCSV_Click);
            // 
            // imgBookCover
            // 
            this.imgBookCover.InitialImage = null;
            this.imgBookCover.Location = new System.Drawing.Point(436, 13);
            this.imgBookCover.Name = "imgBookCover";
            this.imgBookCover.Size = new System.Drawing.Size(574, 291);
            this.imgBookCover.TabIndex = 2;
            this.imgBookCover.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(431, 307);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(580, 26);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(432, 370);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(533, 23);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // lblISBN
            // 
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(431, 404);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(533, 23);
            this.lblISBN.TabIndex = 5;
            this.lblISBN.Text = "ISBN";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(430, 438);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(533, 39);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // lblEdition
            // 
            this.lblEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.Location = new System.Drawing.Point(431, 333);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(533, 23);
            this.lblEdition.TabIndex = 7;
            this.lblEdition.Text = "Edition";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.Location = new System.Drawing.Point(14, 390);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(102, 23);
            this.lblTotalBooks.TabIndex = 8;
            this.lblTotalBooks.Text = "Total Books:";
            // 
            // lblTotalBookNum
            // 
            this.lblTotalBookNum.Location = new System.Drawing.Point(123, 391);
            this.lblTotalBookNum.Name = "lblTotalBookNum";
            this.lblTotalBookNum.Size = new System.Drawing.Size(45, 23);
            this.lblTotalBookNum.TabIndex = 9;
            this.lblTotalBookNum.Text = "#";
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            colTitle});
            this.lvData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvData.Location = new System.Drawing.Point(14, 13);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(379, 343);
            this.lvData.TabIndex = 1;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            this.lvData.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvData_ItemSelectionChanged);
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Location = new System.Drawing.Point(781, 542);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(104, 62);
            this.btnAboutMe.TabIndex = 10;
            this.btnAboutMe.Text = "About Me";
            this.btnAboutMe.UseVisualStyleBackColor = true;
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(903, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 62);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFindIsbn
            // 
            this.btnFindIsbn.Location = new System.Drawing.Point(512, 16);
            this.btnFindIsbn.Name = "btnFindIsbn";
            this.btnFindIsbn.Size = new System.Drawing.Size(85, 62);
            this.btnFindIsbn.TabIndex = 12;
            this.btnFindIsbn.Text = "Search";
            this.btnFindIsbn.UseVisualStyleBackColor = true;
            this.btnFindIsbn.Click += new System.EventHandler(this.btnFindIsbn_Click);
            // 
            // lblLowBook
            // 
            this.lblLowBook.Location = new System.Drawing.Point(201, 417);
            this.lblLowBook.Name = "lblLowBook";
            this.lblLowBook.Size = new System.Drawing.Size(68, 23);
            this.lblLowBook.TabIndex = 14;
            this.lblLowBook.Text = "#";
            // 
            // lblLeastExpnBook
            // 
            this.lblLeastExpnBook.Location = new System.Drawing.Point(14, 416);
            this.lblLeastExpnBook.Name = "lblLeastExpnBook";
            this.lblLeastExpnBook.Size = new System.Drawing.Size(181, 23);
            this.lblLeastExpnBook.TabIndex = 13;
            this.lblLeastExpnBook.Text = "Least Expensive Book:";
            // 
            // lblHighBook
            // 
            this.lblHighBook.Location = new System.Drawing.Point(201, 449);
            this.lblHighBook.Name = "lblHighBook";
            this.lblHighBook.Size = new System.Drawing.Size(79, 23);
            this.lblHighBook.TabIndex = 16;
            this.lblHighBook.Text = "#";
            // 
            // lblMostExpnBook
            // 
            this.lblMostExpnBook.Location = new System.Drawing.Point(14, 448);
            this.lblMostExpnBook.Name = "lblMostExpnBook";
            this.lblMostExpnBook.Size = new System.Drawing.Size(181, 23);
            this.lblMostExpnBook.TabIndex = 15;
            this.lblMostExpnBook.Text = "Most Expensive Book:";
            // 
            // lblAvgBook
            // 
            this.lblAvgBook.Location = new System.Drawing.Point(201, 476);
            this.lblAvgBook.Name = "lblAvgBook";
            this.lblAvgBook.Size = new System.Drawing.Size(79, 23);
            this.lblAvgBook.TabIndex = 18;
            this.lblAvgBook.Text = "#";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(14, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Average Price of Book:";
            // 
            // txtSearchISBN
            // 
            this.txtSearchISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchISBN.Location = new System.Drawing.Point(6, 31);
            this.txtSearchISBN.Name = "txtSearchISBN";
            this.txtSearchISBN.Size = new System.Drawing.Size(500, 34);
            this.txtSearchISBN.TabIndex = 19;
            // 
            // grpLookUpISBN
            // 
            this.grpLookUpISBN.Controls.Add(this.txtSearchISBN);
            this.grpLookUpISBN.Controls.Add(this.btnFindIsbn);
            this.grpLookUpISBN.Location = new System.Drawing.Point(3, 511);
            this.grpLookUpISBN.Name = "grpLookUpISBN";
            this.grpLookUpISBN.Size = new System.Drawing.Size(617, 86);
            this.grpLookUpISBN.TabIndex = 20;
            this.grpLookUpISBN.TabStop = false;
            this.grpLookUpISBN.Text = "ISBN Look Up";
            // 
            // grpBookStats
            // 
            this.grpBookStats.Location = new System.Drawing.Point(9, 363);
            this.grpBookStats.Name = "grpBookStats";
            this.grpBookStats.Size = new System.Drawing.Size(384, 142);
            this.grpBookStats.TabIndex = 21;
            this.grpBookStats.TabStop = false;
            this.grpBookStats.Text = "Book Bank Statistics";
            // 
            // frmBookBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 637);
            this.Controls.Add(this.lblAvgBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHighBook);
            this.Controls.Add(this.lblMostExpnBook);
            this.Controls.Add(this.lblLowBook);
            this.Controls.Add(this.lblLeastExpnBook);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAboutMe);
            this.Controls.Add(this.lblTotalBookNum);
            this.Controls.Add(this.lblTotalBooks);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgBookCover);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.btnUploadCSV);
            this.Controls.Add(this.grpLookUpISBN);
            this.Controls.Add(this.grpBookStats);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBookBank";
            this.Text = "Book Bank";
            this.Load += new System.EventHandler(this.frmBookBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBookCover)).EndInit();
            this.grpLookUpISBN.ResumeLayout(false);
            this.grpLookUpISBN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUploadCSV;
        private System.Windows.Forms.PictureBox imgBookCover;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalBookNum;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.Button btnAboutMe;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFindIsbn;
        private System.Windows.Forms.Label lblLowBook;
        private System.Windows.Forms.Label lblLeastExpnBook;
        private System.Windows.Forms.Label lblHighBook;
        private System.Windows.Forms.Label lblMostExpnBook;
        private System.Windows.Forms.Label lblAvgBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchISBN;
        private System.Windows.Forms.GroupBox grpLookUpISBN;
        private System.Windows.Forms.GroupBox grpBookStats;
    }
}

