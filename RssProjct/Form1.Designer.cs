namespace RssProjct
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
            this.btnAddFeed = new System.Windows.Forms.Button();
            this.btnEditFeeds = new System.Windows.Forms.Button();
            this.btnDeleteFeeds = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lvEpisode = new System.Windows.Forms.ListView();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.cbIntervall = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lvCategory = new System.Windows.Forms.ListBox();
            this.lvFeeds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFeedName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvDescription = new System.Windows.Forms.ListBox();
            this.labelUpdated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.Enabled = false;
            this.btnAddFeed.Location = new System.Drawing.Point(259, 301);
            this.btnAddFeed.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(127, 28);
            this.btnAddFeed.TabIndex = 1;
            this.btnAddFeed.Text = "Add";
            this.btnAddFeed.UseVisualStyleBackColor = true;
            this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
            // 
            // btnEditFeeds
            // 
            this.btnEditFeeds.Enabled = false;
            this.btnEditFeeds.Location = new System.Drawing.Point(807, 355);
            this.btnEditFeeds.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditFeeds.Name = "btnEditFeeds";
            this.btnEditFeeds.Size = new System.Drawing.Size(129, 28);
            this.btnEditFeeds.TabIndex = 2;
            this.btnEditFeeds.Text = "Edit";
            this.btnEditFeeds.UseVisualStyleBackColor = true;
            this.btnEditFeeds.Click += new System.EventHandler(this.btnEditFeeds_Click);
            // 
            // btnDeleteFeeds
            // 
            this.btnDeleteFeeds.Enabled = false;
            this.btnDeleteFeeds.Location = new System.Drawing.Point(807, 300);
            this.btnDeleteFeeds.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFeeds.Name = "btnDeleteFeeds";
            this.btnDeleteFeeds.Size = new System.Drawing.Size(129, 28);
            this.btnDeleteFeeds.TabIndex = 3;
            this.btnDeleteFeeds.Text = "Delete";
            this.btnDeleteFeeds.UseVisualStyleBackColor = true;
            this.btnDeleteFeeds.Click += new System.EventHandler(this.btnDeleteFeeds_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(39, 358);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(359, 22);
            this.txtLink.TabIndex = 4;
            this.txtLink.TextChanged += new System.EventHandler(this.UrlTextChanged);
            // 
            // lvEpisode
            // 
            this.lvEpisode.HideSelection = false;
            this.lvEpisode.Location = new System.Drawing.Point(37, 414);
            this.lvEpisode.Margin = new System.Windows.Forms.Padding(4);
            this.lvEpisode.Name = "lvEpisode";
            this.lvEpisode.Size = new System.Drawing.Size(1384, 121);
            this.lvEpisode.TabIndex = 6;
            this.lvEpisode.UseCompatibleStateImageBehavior = false;
            this.lvEpisode.View = System.Windows.Forms.View.Tile;
            this.lvEpisode.SelectedIndexChanged += new System.EventHandler(this.lvEpisode_SelectedIndexChanged);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Enabled = false;
            this.btnDeleteCategory.Location = new System.Drawing.Point(1261, 154);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(160, 28);
            this.btnDeleteCategory.TabIndex = 10;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Enabled = false;
            this.btnEditCategory.Location = new System.Drawing.Point(1261, 232);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(160, 28);
            this.btnEditCategory.TabIndex = 11;
            this.btnEditCategory.Text = "Edit";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(1044, 313);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(183, 22);
            this.txtCategory.TabIndex = 12;
            this.txtCategory.TextChanged += new System.EventHandler(this.CategoryTextChanged);
            // 
            // cbIntervall
            // 
            this.cbIntervall.FormattingEnabled = true;
            this.cbIntervall.Location = new System.Drawing.Point(417, 358);
            this.cbIntervall.Margin = new System.Windows.Forms.Padding(4);
            this.cbIntervall.Name = "cbIntervall";
            this.cbIntervall.Size = new System.Drawing.Size(160, 24);
            this.cbIntervall.TabIndex = 16;
            this.cbIntervall.SelectedIndexChanged += new System.EventHandler(this.IntervalChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(615, 358);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 24);
            this.cbCategory.TabIndex = 17;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CategoryChanged);
            // 
            // lvCategory
            // 
            this.lvCategory.FormattingEnabled = true;
            this.lvCategory.ItemHeight = 16;
            this.lvCategory.Location = new System.Drawing.Point(1044, 32);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(183, 228);
            this.lvCategory.TabIndex = 18;
            this.lvCategory.SelectedIndexChanged += new System.EventHandler(this.IndexChanged);
            // 
            // lvFeeds
            // 
            this.lvFeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFeeds.HideSelection = false;
            this.lvFeeds.Location = new System.Drawing.Point(1, 31);
            this.lvFeeds.Name = "lvFeeds";
            this.lvFeeds.Size = new System.Drawing.Size(965, 240);
            this.lvFeeds.TabIndex = 19;
            this.lvFeeds.UseCompatibleStateImageBehavior = false;
            this.lvFeeds.View = System.Windows.Forms.View.Details;
            this.lvFeeds.SelectedIndexChanged += new System.EventHandler(this.lvFeeds_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sections";
            this.columnHeader2.Width = 248;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frekvens";
            this.columnHeader3.Width = 259;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Category";
            this.columnHeader4.Width = 305;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "update Intervall";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "podcasts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "feeds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1041, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "categories";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(1261, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFeedName
            // 
            this.txtFeedName.Location = new System.Drawing.Point(37, 306);
            this.txtFeedName.Name = "txtFeedName";
            this.txtFeedName.Size = new System.Drawing.Size(200, 22);
            this.txtFeedName.TabIndex = 30;
            this.txtFeedName.TextChanged += new System.EventHandler(this.FeedNameChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "feed name";
            // 
            // lvDescription
            // 
            this.lvDescription.FormattingEnabled = true;
            this.lvDescription.ItemHeight = 16;
            this.lvDescription.Location = new System.Drawing.Point(37, 559);
            this.lvDescription.Name = "lvDescription";
            this.lvDescription.Size = new System.Drawing.Size(1384, 84);
            this.lvDescription.TabIndex = 32;
            // 
            // labelUpdated
            // 
            this.labelUpdated.AutoSize = true;
            this.labelUpdated.Location = new System.Drawing.Point(187, 8);
            this.labelUpdated.Name = "labelUpdated";
            this.labelUpdated.Size = new System.Drawing.Size(0, 17);
            this.labelUpdated.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 668);
            this.Controls.Add(this.labelUpdated);
            this.Controls.Add(this.lvDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFeedName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFeeds);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbIntervall);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.lvEpisode);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnDeleteFeeds);
            this.Controls.Add(this.btnEditFeeds);
            this.Controls.Add(this.btnAddFeed);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddFeed;
        private System.Windows.Forms.Button btnEditFeeds;
        private System.Windows.Forms.Button btnDeleteFeeds;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ListView lvEpisode;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ComboBox cbIntervall;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListBox lvCategory;
        private System.Windows.Forms.ListView lvFeeds;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFeedName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lvDescription;
        private System.Windows.Forms.Label labelUpdated;
    }
}

