namespace Program4
{
    partial class Form1
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
            this.originZipTxtBox = new System.Windows.Forms.TextBox();
            this.destZipTxtBox = new System.Windows.Forms.TextBox();
            this.lengthTxtBox = new System.Windows.Forms.TextBox();
            this.widthTxtBox = new System.Windows.Forms.TextBox();
            this.heightTxtBox = new System.Windows.Forms.TextBox();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.originZipLbl = new System.Windows.Forms.Label();
            this.destZipLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.createPackageBttn = new System.Windows.Forms.Button();
            this.packagesListBox = new System.Windows.Forms.ListBox();
            this.detailsBttn = new System.Windows.Forms.Button();
            this.sendToBttn = new System.Windows.Forms.Button();
            this.sendFromBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originZipTxtBox
            // 
            this.originZipTxtBox.Location = new System.Drawing.Point(113, 27);
            this.originZipTxtBox.Name = "originZipTxtBox";
            this.originZipTxtBox.Size = new System.Drawing.Size(100, 20);
            this.originZipTxtBox.TabIndex = 0;
            // 
            // destZipTxtBox
            // 
            this.destZipTxtBox.Location = new System.Drawing.Point(113, 70);
            this.destZipTxtBox.Name = "destZipTxtBox";
            this.destZipTxtBox.Size = new System.Drawing.Size(100, 20);
            this.destZipTxtBox.TabIndex = 1;
            // 
            // lengthTxtBox
            // 
            this.lengthTxtBox.Location = new System.Drawing.Point(113, 158);
            this.lengthTxtBox.Name = "lengthTxtBox";
            this.lengthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTxtBox.TabIndex = 3;
            // 
            // widthTxtBox
            // 
            this.widthTxtBox.Location = new System.Drawing.Point(113, 202);
            this.widthTxtBox.Name = "widthTxtBox";
            this.widthTxtBox.Size = new System.Drawing.Size(100, 20);
            this.widthTxtBox.TabIndex = 4;
            // 
            // heightTxtBox
            // 
            this.heightTxtBox.Location = new System.Drawing.Point(113, 240);
            this.heightTxtBox.Name = "heightTxtBox";
            this.heightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.heightTxtBox.TabIndex = 5;
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Location = new System.Drawing.Point(113, 116);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.weightTxtBox.TabIndex = 2;
            // 
            // originZipLbl
            // 
            this.originZipLbl.AutoSize = true;
            this.originZipLbl.Location = new System.Drawing.Point(12, 30);
            this.originZipLbl.Name = "originZipLbl";
            this.originZipLbl.Size = new System.Drawing.Size(80, 13);
            this.originZipLbl.TabIndex = 6;
            this.originZipLbl.Text = "Origin Zip Code";
            // 
            // destZipLbl
            // 
            this.destZipLbl.AutoSize = true;
            this.destZipLbl.Location = new System.Drawing.Point(1, 73);
            this.destZipLbl.Name = "destZipLbl";
            this.destZipLbl.Size = new System.Drawing.Size(106, 13);
            this.destZipLbl.TabIndex = 7;
            this.destZipLbl.Text = "Destination Zip Code";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(28, 161);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(40, 13);
            this.lengthLbl.TabIndex = 8;
            this.lengthLbl.Text = "Length";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(28, 205);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(35, 13);
            this.widthLbl.TabIndex = 9;
            this.widthLbl.Text = "Width";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(28, 243);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(38, 13);
            this.heightLbl.TabIndex = 10;
            this.heightLbl.Text = "Height";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(28, 119);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(41, 13);
            this.weightLbl.TabIndex = 11;
            this.weightLbl.Text = "Weight";
            // 
            // createPackageBttn
            // 
            this.createPackageBttn.Location = new System.Drawing.Point(395, 27);
            this.createPackageBttn.Name = "createPackageBttn";
            this.createPackageBttn.Size = new System.Drawing.Size(104, 42);
            this.createPackageBttn.TabIndex = 6;
            this.createPackageBttn.Text = "Create Package";
            this.createPackageBttn.UseVisualStyleBackColor = true;
            this.createPackageBttn.Click += new System.EventHandler(this.createPackageBttn_Click);
            // 
            // packagesListBox
            // 
            this.packagesListBox.FormattingEnabled = true;
            this.packagesListBox.Location = new System.Drawing.Point(251, 24);
            this.packagesListBox.Name = "packagesListBox";
            this.packagesListBox.Size = new System.Drawing.Size(138, 251);
            this.packagesListBox.TabIndex = 8;
            // 
            // detailsBttn
            // 
            this.detailsBttn.Location = new System.Drawing.Point(395, 95);
            this.detailsBttn.Name = "detailsBttn";
            this.detailsBttn.Size = new System.Drawing.Size(104, 41);
            this.detailsBttn.TabIndex = 9;
            this.detailsBttn.Text = "Details";
            this.detailsBttn.UseVisualStyleBackColor = true;
            this.detailsBttn.Click += new System.EventHandler(this.detailsBttn_Click);
            // 
            // sendToBttn
            // 
            this.sendToBttn.Location = new System.Drawing.Point(395, 161);
            this.sendToBttn.Name = "sendToBttn";
            this.sendToBttn.Size = new System.Drawing.Size(104, 46);
            this.sendToBttn.TabIndex = 10;
            this.sendToBttn.Text = "Send to U of L";
            this.sendToBttn.UseVisualStyleBackColor = true;
            this.sendToBttn.Click += new System.EventHandler(this.sendToBttn_Click);
            // 
            // sendFromBttn
            // 
            this.sendFromBttn.Location = new System.Drawing.Point(395, 226);
            this.sendFromBttn.Name = "sendFromBttn";
            this.sendFromBttn.Size = new System.Drawing.Size(104, 46);
            this.sendFromBttn.TabIndex = 11;
            this.sendFromBttn.Text = "Send from U of L";
            this.sendFromBttn.UseVisualStyleBackColor = true;
            this.sendFromBttn.Click += new System.EventHandler(this.sendFromBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(516, 303);
            this.Controls.Add(this.sendFromBttn);
            this.Controls.Add(this.sendToBttn);
            this.Controls.Add(this.detailsBttn);
            this.Controls.Add(this.packagesListBox);
            this.Controls.Add(this.createPackageBttn);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.destZipLbl);
            this.Controls.Add(this.originZipLbl);
            this.Controls.Add(this.weightTxtBox);
            this.Controls.Add(this.heightTxtBox);
            this.Controls.Add(this.widthTxtBox);
            this.Controls.Add(this.lengthTxtBox);
            this.Controls.Add(this.destZipTxtBox);
            this.Controls.Add(this.originZipTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originZipTxtBox;
        private System.Windows.Forms.TextBox destZipTxtBox;
        private System.Windows.Forms.TextBox lengthTxtBox;
        private System.Windows.Forms.TextBox widthTxtBox;
        private System.Windows.Forms.TextBox heightTxtBox;
        private System.Windows.Forms.TextBox weightTxtBox;
        private System.Windows.Forms.Label originZipLbl;
        private System.Windows.Forms.Label destZipLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Button createPackageBttn;
        private System.Windows.Forms.ListBox packagesListBox;
        private System.Windows.Forms.Button detailsBttn;
        private System.Windows.Forms.Button sendToBttn;
        private System.Windows.Forms.Button sendFromBttn;
    }
}

