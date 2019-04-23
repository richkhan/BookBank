namespace BOOKBANK
{
    partial class frmLookUpISBN
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
            this.btnLookUpExit = new System.Windows.Forms.Button();
            this.txtLookUpISBN = new System.Windows.Forms.TextBox();
            this.btnSearchISBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLookUpExit
            // 
            this.btnLookUpExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUpExit.Location = new System.Drawing.Point(250, 93);
            this.btnLookUpExit.Name = "btnLookUpExit";
            this.btnLookUpExit.Size = new System.Drawing.Size(220, 39);
            this.btnLookUpExit.TabIndex = 0;
            this.btnLookUpExit.Text = "Exit";
            this.btnLookUpExit.UseVisualStyleBackColor = true;
            this.btnLookUpExit.Click += new System.EventHandler(this.btnLookUpExit_Click);
            // 
            // txtLookUpISBN
            // 
            this.txtLookUpISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLookUpISBN.Location = new System.Drawing.Point(35, 34);
            this.txtLookUpISBN.Name = "txtLookUpISBN";
            this.txtLookUpISBN.Size = new System.Drawing.Size(567, 34);
            this.txtLookUpISBN.TabIndex = 1;
            // 
            // btnSearchISBN
            // 
            this.btnSearchISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchISBN.Location = new System.Drawing.Point(609, 31);
            this.btnSearchISBN.Name = "btnSearchISBN";
            this.btnSearchISBN.Size = new System.Drawing.Size(179, 41);
            this.btnSearchISBN.TabIndex = 2;
            this.btnSearchISBN.Text = "Search";
            this.btnSearchISBN.UseVisualStyleBackColor = true;
            this.btnSearchISBN.Click += new System.EventHandler(this.btnSearchISBN_Click);
            // 
            // frmLookUpISBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 150);
            this.Controls.Add(this.btnSearchISBN);
            this.Controls.Add(this.txtLookUpISBN);
            this.Controls.Add(this.btnLookUpExit);
            this.Name = "frmLookUpISBN";
            this.Text = "ISBN Look Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLookUpExit;
        private System.Windows.Forms.TextBox txtLookUpISBN;
        private System.Windows.Forms.Button btnSearchISBN;
    }
}