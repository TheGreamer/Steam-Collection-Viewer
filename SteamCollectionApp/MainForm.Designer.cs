namespace SteamCollectionApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.labelCollectionName = new System.Windows.Forms.Label();
            this.labelGeneratorName = new System.Windows.Forms.Label();
            this.labelItemCount = new System.Windows.Forms.Label();
            this.labelFavCount = new System.Windows.Forms.Label();
            this.labelUniqueFavCount = new System.Windows.Forms.Label();
            this.labelVisitorCount = new System.Windows.Forms.Label();
            this.labelPostDate = new System.Windows.Forms.Label();
            this.labelUpdateDate = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.listBoxItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxItems.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxItems.ForeColor = System.Drawing.Color.White;
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 24;
            this.listBoxItems.Location = new System.Drawing.Point(0, 340);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(745, 340);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedValueChanged += new System.EventHandler(this.ListBoxItemsOnSelectedValueChanged);
            // 
            // labelCollectionName
            // 
            this.labelCollectionName.AutoSize = true;
            this.labelCollectionName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelCollectionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.labelCollectionName.Location = new System.Drawing.Point(12, 12);
            this.labelCollectionName.Name = "labelCollectionName";
            this.labelCollectionName.Size = new System.Drawing.Size(35, 31);
            this.labelCollectionName.TabIndex = 1;
            this.labelCollectionName.Text = "...";
            // 
            // labelGeneratorName
            // 
            this.labelGeneratorName.AutoSize = true;
            this.labelGeneratorName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelGeneratorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.labelGeneratorName.Location = new System.Drawing.Point(12, 52);
            this.labelGeneratorName.Name = "labelGeneratorName";
            this.labelGeneratorName.Size = new System.Drawing.Size(35, 31);
            this.labelGeneratorName.TabIndex = 2;
            this.labelGeneratorName.Text = "...";
            // 
            // labelItemCount
            // 
            this.labelItemCount.AutoSize = true;
            this.labelItemCount.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.labelItemCount.Location = new System.Drawing.Point(12, 92);
            this.labelItemCount.Name = "labelItemCount";
            this.labelItemCount.Size = new System.Drawing.Size(35, 31);
            this.labelItemCount.TabIndex = 3;
            this.labelItemCount.Text = "...";
            // 
            // labelFavCount
            // 
            this.labelFavCount.AutoSize = true;
            this.labelFavCount.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelFavCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.labelFavCount.Location = new System.Drawing.Point(12, 132);
            this.labelFavCount.Name = "labelFavCount";
            this.labelFavCount.Size = new System.Drawing.Size(35, 31);
            this.labelFavCount.TabIndex = 4;
            this.labelFavCount.Text = "...";
            // 
            // labelUniqueFavCount
            // 
            this.labelUniqueFavCount.AutoSize = true;
            this.labelUniqueFavCount.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelUniqueFavCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.labelUniqueFavCount.Location = new System.Drawing.Point(12, 172);
            this.labelUniqueFavCount.Name = "labelUniqueFavCount";
            this.labelUniqueFavCount.Size = new System.Drawing.Size(35, 31);
            this.labelUniqueFavCount.TabIndex = 5;
            this.labelUniqueFavCount.Text = "...";
            // 
            // labelVisitorCount
            // 
            this.labelVisitorCount.AutoSize = true;
            this.labelVisitorCount.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelVisitorCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.labelVisitorCount.Location = new System.Drawing.Point(12, 212);
            this.labelVisitorCount.Name = "labelVisitorCount";
            this.labelVisitorCount.Size = new System.Drawing.Size(35, 31);
            this.labelVisitorCount.TabIndex = 6;
            this.labelVisitorCount.Text = "...";
            // 
            // labelPostDate
            // 
            this.labelPostDate.AutoSize = true;
            this.labelPostDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelPostDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.labelPostDate.Location = new System.Drawing.Point(12, 252);
            this.labelPostDate.Name = "labelPostDate";
            this.labelPostDate.Size = new System.Drawing.Size(35, 31);
            this.labelPostDate.TabIndex = 7;
            this.labelPostDate.Text = "...";
            // 
            // labelUpdateDate
            // 
            this.labelUpdateDate.AutoSize = true;
            this.labelUpdateDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelUpdateDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.labelUpdateDate.Location = new System.Drawing.Point(12, 292);
            this.labelUpdateDate.Name = "labelUpdateDate";
            this.labelUpdateDate.Size = new System.Drawing.Size(35, 31);
            this.labelUpdateDate.TabIndex = 8;
            this.labelUpdateDate.Text = "...";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panel.Controls.Add(this.buttonGoBack);
            this.panel.Controls.Add(this.buttonSearch);
            this.panel.Controls.Add(this.textBoxSearch);
            this.panel.Controls.Add(this.labelCollectionName);
            this.panel.Controls.Add(this.labelGeneratorName);
            this.panel.Controls.Add(this.labelUpdateDate);
            this.panel.Controls.Add(this.labelItemCount);
            this.panel.Controls.Add(this.labelPostDate);
            this.panel.Controls.Add(this.labelFavCount);
            this.panel.Controls.Add(this.labelVisitorCount);
            this.panel.Controls.Add(this.labelUniqueFavCount);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.webBrowser);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(921, 340);
            this.panel.TabIndex = 10;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBoxSearch.ForeColor = System.Drawing.Color.White;
            this.textBoxSearch.Location = new System.Drawing.Point(700, 288);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(216, 39);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.Text = "Numara...";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.Enter += new System.EventHandler(this.TextBoxSearchOnEnter);
            this.textBoxSearch.Leave += new System.EventHandler(this.TextBoxSearchOnLeave);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(3, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(913, 314);
            this.webBrowser.TabIndex = 14;
            this.webBrowser.Tag = "Browser";
            this.webBrowser.Visible = false;
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.listBoxNumbers.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxNumbers.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxNumbers.ForeColor = System.Drawing.Color.White;
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.ItemHeight = 24;
            this.listBoxNumbers.Location = new System.Drawing.Point(751, 340);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(170, 340);
            this.listBoxNumbers.TabIndex = 11;
            this.listBoxNumbers.SelectedValueChanged += new System.EventHandler(this.ListBoxNumbersOnSelectedValueChanged);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoBack.BackgroundImage = global::SteamCollectionApp.Properties.Resources.go_back_icon;
            this.buttonGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGoBack.Location = new System.Drawing.Point(866, 12);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(50, 39);
            this.buttonGoBack.TabIndex = 15;
            this.buttonGoBack.Tag = "Browser";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Visible = false;
            this.buttonGoBack.Click += new System.EventHandler(this.ButtonGoBackOnClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackgroundImage = global::SteamCollectionApp.Properties.Resources.search_icon;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.Location = new System.Drawing.Point(644, 288);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 39);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchOnClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(644, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(275, 275);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(921, 680);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.panel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Koleksiyon Görüntüleyici";
            this.Load += new System.EventHandler(this.MainFormOnLoad);
            this.SizeChanged += new System.EventHandler(this.MainFormOnSizeChanged);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Label labelCollectionName;
        private System.Windows.Forms.Label labelGeneratorName;
        private System.Windows.Forms.Label labelItemCount;
        private System.Windows.Forms.Label labelFavCount;
        private System.Windows.Forms.Label labelUniqueFavCount;
        private System.Windows.Forms.Label labelVisitorCount;
        private System.Windows.Forms.Label labelPostDate;
        private System.Windows.Forms.Label labelUpdateDate;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.ListBox listBoxNumbers;
    }
}