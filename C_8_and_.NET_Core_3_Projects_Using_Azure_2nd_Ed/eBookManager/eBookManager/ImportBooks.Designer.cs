namespace eBookManager
{
    partial class ImportBooks
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
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gbVirtualStorageSpaces = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveStorageSpace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddNewStorageSpace = new System.Windows.Forms.Button();
            this.dlVirtualStorageSpaces = new System.Windows.Forms.ComboBox();
            this.gbFileDetails = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblLastAccessed = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.dtCreated = new System.Windows.Forms.DateTimePicker();
            this.dtLastAccessed = new System.Windows.Forms.DateTimePicker();
            this.tbFileExtension = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.gbBookDetails = new System.Windows.Forms.GroupBox();
            this.btnAddBookToStorageSpace = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.lblClassification = new System.Windows.Forms.Label();
            this.dtDatePublished = new System.Windows.Forms.DateTimePicker();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.gbVirtualStorageSpaces.SuspendLayout();
            this.gbFileDetails.SuspendLayout();
            this.gbBookDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(13, 13);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(160, 29);
            this.btnSelectSourceFolder.TabIndex = 0;
            this.btnSelectSourceFolder.Text = "Select Source Folder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 49);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(468, 302);
            this.treeView1.TabIndex = 1;
            // 
            // gbVirtualStorageSpaces
            // 
            this.gbVirtualStorageSpaces.Controls.Add(this.tbDescription);
            this.gbVirtualStorageSpaces.Controls.Add(this.lblDescription);
            this.gbVirtualStorageSpaces.Controls.Add(this.btnCancel);
            this.gbVirtualStorageSpaces.Controls.Add(this.btnSaveStorageSpace);
            this.gbVirtualStorageSpaces.Controls.Add(this.textBox1);
            this.gbVirtualStorageSpaces.Controls.Add(this.btnAddNewStorageSpace);
            this.gbVirtualStorageSpaces.Controls.Add(this.dlVirtualStorageSpaces);
            this.gbVirtualStorageSpaces.Location = new System.Drawing.Point(12, 357);
            this.gbVirtualStorageSpaces.Name = "gbVirtualStorageSpaces";
            this.gbVirtualStorageSpaces.Size = new System.Drawing.Size(469, 223);
            this.gbVirtualStorageSpaces.TabIndex = 2;
            this.gbVirtualStorageSpaces.TabStop = false;
            this.gbVirtualStorageSpaces.Text = "Virtual Storage Spaces";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 26);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveStorageSpace
            // 
            this.btnSaveStorageSpace.Location = new System.Drawing.Point(346, 26);
            this.btnSaveStorageSpace.Name = "btnSaveStorageSpace";
            this.btnSaveStorageSpace.Size = new System.Drawing.Size(48, 29);
            this.btnSaveStorageSpace.TabIndex = 3;
            this.btnSaveStorageSpace.Text = "Save";
            this.btnSaveStorageSpace.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            // 
            // btnAddNewStorageSpace
            // 
            this.btnAddNewStorageSpace.Location = new System.Drawing.Point(159, 26);
            this.btnAddNewStorageSpace.Name = "btnAddNewStorageSpace";
            this.btnAddNewStorageSpace.Size = new System.Drawing.Size(50, 29);
            this.btnAddNewStorageSpace.TabIndex = 1;
            this.btnAddNewStorageSpace.Text = "Add";
            this.btnAddNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // dlVirtualStorageSpaces
            // 
            this.dlVirtualStorageSpaces.FormattingEnabled = true;
            this.dlVirtualStorageSpaces.Location = new System.Drawing.Point(6, 28);
            this.dlVirtualStorageSpaces.Name = "dlVirtualStorageSpaces";
            this.dlVirtualStorageSpaces.Size = new System.Drawing.Size(147, 28);
            this.dlVirtualStorageSpaces.TabIndex = 0;
            // 
            // gbFileDetails
            // 
            this.gbFileDetails.Controls.Add(this.lblSize);
            this.gbFileDetails.Controls.Add(this.tbSize);
            this.gbFileDetails.Controls.Add(this.tbPath);
            this.gbFileDetails.Controls.Add(this.lblPath);
            this.gbFileDetails.Controls.Add(this.lblCreated);
            this.gbFileDetails.Controls.Add(this.lblLastAccessed);
            this.gbFileDetails.Controls.Add(this.lblExtension);
            this.gbFileDetails.Controls.Add(this.dtCreated);
            this.gbFileDetails.Controls.Add(this.dtLastAccessed);
            this.gbFileDetails.Controls.Add(this.tbFileExtension);
            this.gbFileDetails.Controls.Add(this.lblName);
            this.gbFileDetails.Controls.Add(this.tbFileName);
            this.gbFileDetails.Location = new System.Drawing.Point(487, 13);
            this.gbFileDetails.Name = "gbFileDetails";
            this.gbFileDetails.Size = new System.Drawing.Size(301, 228);
            this.gbFileDetails.TabIndex = 3;
            this.gbFileDetails.TabStop = false;
            this.gbFileDetails.Text = "File Details";
            this.gbFileDetails.Enter += new System.EventHandler(this.gbFileDetails_Enter);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(78, 194);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(39, 20);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Size:";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(123, 191);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(163, 27);
            this.tbSize.TabIndex = 10;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(123, 157);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(163, 27);
            this.tbPath.TabIndex = 9;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(77, 160);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(40, 20);
            this.lblPath.TabIndex = 8;
            this.lblPath.Text = "Path:";
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Location = new System.Drawing.Point(53, 129);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(64, 20);
            this.lblCreated.TabIndex = 7;
            this.lblCreated.Text = "Created:";
            // 
            // lblLastAccessed
            // 
            this.lblLastAccessed.AutoSize = true;
            this.lblLastAccessed.Location = new System.Drawing.Point(14, 95);
            this.lblLastAccessed.Name = "lblLastAccessed";
            this.lblLastAccessed.Size = new System.Drawing.Size(103, 20);
            this.lblLastAccessed.TabIndex = 6;
            this.lblLastAccessed.Text = "Last Accessed:";
            this.lblLastAccessed.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(42, 60);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(75, 20);
            this.lblExtension.TabIndex = 5;
            this.lblExtension.Text = "Extension:";
            // 
            // dtCreated
            // 
            this.dtCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreated.Location = new System.Drawing.Point(123, 124);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Size = new System.Drawing.Size(163, 27);
            this.dtCreated.TabIndex = 4;
            // 
            // dtLastAccessed
            // 
            this.dtLastAccessed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLastAccessed.Location = new System.Drawing.Point(123, 90);
            this.dtLastAccessed.Name = "dtLastAccessed";
            this.dtLastAccessed.Size = new System.Drawing.Size(163, 27);
            this.dtLastAccessed.TabIndex = 3;
            // 
            // tbFileExtension
            // 
            this.tbFileExtension.Location = new System.Drawing.Point(123, 57);
            this.tbFileExtension.Name = "tbFileExtension";
            this.tbFileExtension.Size = new System.Drawing.Size(163, 27);
            this.tbFileExtension.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(123, 23);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(163, 27);
            this.tbFileName.TabIndex = 0;
            // 
            // gbBookDetails
            // 
            this.gbBookDetails.Controls.Add(this.btnAddBookToStorageSpace);
            this.gbBookDetails.Controls.Add(this.comboBox1);
            this.gbBookDetails.Controls.Add(this.tbCategory);
            this.gbBookDetails.Controls.Add(this.lblClassification);
            this.gbBookDetails.Controls.Add(this.dtDatePublished);
            this.gbBookDetails.Controls.Add(this.tbISBN);
            this.gbBookDetails.Controls.Add(this.tbPrice);
            this.gbBookDetails.Controls.Add(this.lblCategory);
            this.gbBookDetails.Controls.Add(this.tbPublisher);
            this.gbBookDetails.Controls.Add(this.tbAuthor);
            this.gbBookDetails.Controls.Add(this.lblDatePublished);
            this.gbBookDetails.Controls.Add(this.tbTitle);
            this.gbBookDetails.Controls.Add(this.lblTitle);
            this.gbBookDetails.Controls.Add(this.lblAuthor);
            this.gbBookDetails.Controls.Add(this.lblISBN);
            this.gbBookDetails.Controls.Add(this.lblPublisher);
            this.gbBookDetails.Controls.Add(this.lblPrice);
            this.gbBookDetails.Location = new System.Drawing.Point(487, 247);
            this.gbBookDetails.Name = "gbBookDetails";
            this.gbBookDetails.Size = new System.Drawing.Size(300, 333);
            this.gbBookDetails.TabIndex = 4;
            this.gbBookDetails.TabStop = false;
            this.gbBookDetails.Text = "Book Details";
            // 
            // btnAddBookToStorageSpace
            // 
            this.btnAddBookToStorageSpace.Location = new System.Drawing.Point(123, 291);
            this.btnAddBookToStorageSpace.Name = "btnAddBookToStorageSpace";
            this.btnAddBookToStorageSpace.Size = new System.Drawing.Size(165, 29);
            this.btnAddBookToStorageSpace.TabIndex = 16;
            this.btnAddBookToStorageSpace.Text = "Add To Storage Space";
            this.btnAddBookToStorageSpace.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(124, 223);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(162, 27);
            this.tbCategory.TabIndex = 14;
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(19, 260);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(99, 20);
            this.lblClassification.TabIndex = 7;
            this.lblClassification.Text = "Classification:";
            // 
            // dtDatePublished
            // 
            this.dtDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatePublished.Location = new System.Drawing.Point(124, 189);
            this.dtDatePublished.Name = "dtDatePublished";
            this.dtDatePublished.Size = new System.Drawing.Size(162, 27);
            this.dtDatePublished.TabIndex = 13;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(124, 155);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(162, 27);
            this.tbISBN.TabIndex = 12;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(124, 121);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(163, 27);
            this.tbPrice.TabIndex = 11;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(46, 226);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(124, 88);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(163, 27);
            this.tbPublisher.TabIndex = 10;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(124, 55);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(163, 27);
            this.tbAuthor.TabIndex = 9;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Location = new System.Drawing.Point(6, 194);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(112, 20);
            this.lblDatePublished.TabIndex = 5;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(124, 21);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(163, 27);
            this.tbTitle.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(77, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(61, 58);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 20);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(74, 158);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(44, 20);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(46, 91);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(72, 20);
            this.lblPublisher.TabIndex = 2;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(74, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 63);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(7, 87);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(456, 130);
            this.tbDescription.TabIndex = 6;
            // 
            // ImportBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.gbBookDetails);
            this.Controls.Add(this.gbFileDetails);
            this.Controls.Add(this.gbVirtualStorageSpaces);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Controls.Add(this.treeView1);
            this.Name = "ImportBooks";
            this.Text = "ImportBooks";
            this.Load += new System.EventHandler(this.ImportBooks_Load);
            this.gbVirtualStorageSpaces.ResumeLayout(false);
            this.gbVirtualStorageSpaces.PerformLayout();
            this.gbFileDetails.ResumeLayout(false);
            this.gbFileDetails.PerformLayout();
            this.gbBookDetails.ResumeLayout(false);
            this.gbBookDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox gbVirtualStorageSpaces;
        private System.Windows.Forms.GroupBox gbFileDetails;
        private System.Windows.Forms.Label lblLastAccessed;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.DateTimePicker dtCreated;
        private System.Windows.Forms.DateTimePicker dtLastAccessed;
        private System.Windows.Forms.TextBox tbFileExtension;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.GroupBox gbBookDetails;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.DateTimePicker dtDatePublished;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnAddNewStorageSpace;
        private System.Windows.Forms.ComboBox dlVirtualStorageSpaces;
        private System.Windows.Forms.Button btnAddBookToStorageSpace;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveStorageSpace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}