namespace FormUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.findAllBtn = new System.Windows.Forms.Button();
            this.FirstNameEntryLbl = new System.Windows.Forms.Label();
            this.firstNameEntryTxt = new System.Windows.Forms.TextBox();
            this.LastNameEntryLbl = new System.Windows.Forms.Label();
            this.lastNameEntryTxt = new System.Windows.Forms.TextBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 16;
            this.peopleFoundListbox.Location = new System.Drawing.Point(12, 44);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(363, 340);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(98, 6);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(119, 22);
            this.LastNameTxt.TabIndex = 1;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(12, 9);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(80, 17);
            this.LastNameLbl.TabIndex = 2;
            this.LastNameLbl.Text = "Last Name:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(223, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(152, 28);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // findAllBtn
            // 
            this.findAllBtn.Location = new System.Drawing.Point(13, 405);
            this.findAllBtn.Name = "findAllBtn";
            this.findAllBtn.Size = new System.Drawing.Size(169, 33);
            this.findAllBtn.TabIndex = 4;
            this.findAllBtn.Text = "Load All";
            this.findAllBtn.UseVisualStyleBackColor = true;
            this.findAllBtn.Click += new System.EventHandler(this.findAllBtn_Click);
            // 
            // FirstNameEntryLbl
            // 
            this.FirstNameEntryLbl.AutoSize = true;
            this.FirstNameEntryLbl.Location = new System.Drawing.Point(482, 81);
            this.FirstNameEntryLbl.Name = "FirstNameEntryLbl";
            this.FirstNameEntryLbl.Size = new System.Drawing.Size(80, 17);
            this.FirstNameEntryLbl.TabIndex = 6;
            this.FirstNameEntryLbl.Text = "First Name:";
            // 
            // firstNameEntryTxt
            // 
            this.firstNameEntryTxt.Location = new System.Drawing.Point(568, 78);
            this.firstNameEntryTxt.Name = "firstNameEntryTxt";
            this.firstNameEntryTxt.Size = new System.Drawing.Size(119, 22);
            this.firstNameEntryTxt.TabIndex = 5;
            // 
            // LastNameEntryLbl
            // 
            this.LastNameEntryLbl.AutoSize = true;
            this.LastNameEntryLbl.Location = new System.Drawing.Point(482, 109);
            this.LastNameEntryLbl.Name = "LastNameEntryLbl";
            this.LastNameEntryLbl.Size = new System.Drawing.Size(80, 17);
            this.LastNameEntryLbl.TabIndex = 8;
            this.LastNameEntryLbl.Text = "Last Name:";
            // 
            // lastNameEntryTxt
            // 
            this.lastNameEntryTxt.Location = new System.Drawing.Point(568, 106);
            this.lastNameEntryTxt.Name = "lastNameEntryTxt";
            this.lastNameEntryTxt.Size = new System.Drawing.Size(119, 22);
            this.lastNameEntryTxt.TabIndex = 7;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(499, 146);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(169, 33);
            this.InsertBtn.TabIndex = 9;
            this.InsertBtn.Text = "Insert Person";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.LastNameEntryLbl);
            this.Controls.Add(this.lastNameEntryTxt);
            this.Controls.Add(this.FirstNameEntryLbl);
            this.Controls.Add(this.firstNameEntryTxt);
            this.Controls.Add(this.findAllBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.peopleFoundListbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button findAllBtn;
        private System.Windows.Forms.Label FirstNameEntryLbl;
        private System.Windows.Forms.TextBox firstNameEntryTxt;
        private System.Windows.Forms.Label LastNameEntryLbl;
        private System.Windows.Forms.TextBox lastNameEntryTxt;
        private System.Windows.Forms.Button InsertBtn;
    }
}

