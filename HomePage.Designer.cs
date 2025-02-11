namespace PlakDükkanıYöneticiModülü
{
    partial class HomePage
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
            groupBox1 = new GroupBox();
            btnListAll = new Button();
            btnDiscountedAlbums = new Button();
            btnLastTenAlbum = new Button();
            btnListOnSale = new Button();
            btnListNotOnSale = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvAlbums = new DataGridView();
            btnAddAlbum = new Button();
            lblErrorMessage = new Label();
            rdIsNotSale = new RadioButton();
            rdSale = new RadioButton();
            label1 = new Label();
            dtpReleaseDate = new DateTimePicker();
            lblReleaseDate = new Label();
            txtDiscountText = new TextBox();
            lblDiscountRate = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtArtistorGroup = new TextBox();
            lblArtist = new Label();
            txtAlbumName = new TextBox();
            lblAlbumName = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnListAll);
            groupBox1.Controls.Add(btnDiscountedAlbums);
            groupBox1.Controls.Add(btnLastTenAlbum);
            groupBox1.Controls.Add(btnListOnSale);
            groupBox1.Controls.Add(btnListNotOnSale);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(dgvAlbums);
            groupBox1.Controls.Add(btnAddAlbum);
            groupBox1.Controls.Add(lblErrorMessage);
            groupBox1.Controls.Add(rdIsNotSale);
            groupBox1.Controls.Add(rdSale);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpReleaseDate);
            groupBox1.Controls.Add(lblReleaseDate);
            groupBox1.Controls.Add(txtDiscountText);
            groupBox1.Controls.Add(lblDiscountRate);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(txtArtistorGroup);
            groupBox1.Controls.Add(lblArtist);
            groupBox1.Controls.Add(txtAlbumName);
            groupBox1.Controls.Add(lblAlbumName);
            groupBox1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(38, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1211, 482);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Album Manager Page";
            // 
            // btnListAll
            // 
            btnListAll.Location = new Point(982, 329);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(197, 47);
            btnListAll.TabIndex = 22;
            btnListAll.Text = "List All";
            btnListAll.UseVisualStyleBackColor = true;
            btnListAll.Click += btnListAll_Click;
            // 
            // btnDiscountedAlbums
            // 
            btnDiscountedAlbums.Location = new Point(982, 252);
            btnDiscountedAlbums.Name = "btnDiscountedAlbums";
            btnDiscountedAlbums.Size = new Size(197, 60);
            btnDiscountedAlbums.TabIndex = 21;
            btnDiscountedAlbums.Text = "List Discounted Albums";
            btnDiscountedAlbums.UseVisualStyleBackColor = true;
            btnDiscountedAlbums.Click += btnDiscountedAlbums_Click;
            // 
            // btnLastTenAlbum
            // 
            btnLastTenAlbum.Location = new Point(982, 181);
            btnLastTenAlbum.Name = "btnLastTenAlbum";
            btnLastTenAlbum.Size = new Size(197, 58);
            btnLastTenAlbum.TabIndex = 20;
            btnLastTenAlbum.Text = "List Last Ten Albums";
            btnLastTenAlbum.UseVisualStyleBackColor = true;
            btnLastTenAlbum.Click += btnLastTenAlbum_Click;
            // 
            // btnListOnSale
            // 
            btnListOnSale.Location = new Point(982, 109);
            btnListOnSale.Name = "btnListOnSale";
            btnListOnSale.Size = new Size(197, 48);
            btnListOnSale.TabIndex = 19;
            btnListOnSale.Text = "List OnSale";
            btnListOnSale.UseVisualStyleBackColor = true;
            btnListOnSale.Click += btnListOnSale_Click;
            // 
            // btnListNotOnSale
            // 
            btnListNotOnSale.Location = new Point(982, 34);
            btnListNotOnSale.Name = "btnListNotOnSale";
            btnListNotOnSale.Size = new Size(197, 53);
            btnListNotOnSale.TabIndex = 18;
            btnListNotOnSale.Text = "List Not On Sale";
            btnListNotOnSale.UseVisualStyleBackColor = true;
            btnListNotOnSale.Click += btnListNotOnSale_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(709, 389);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(256, 46);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(406, 389);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(259, 46);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAlbums
            // 
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbums.Location = new Point(406, 34);
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.RowHeadersWidth = 51;
            dgvAlbums.Size = new Size(559, 342);
            dgvAlbums.TabIndex = 15;
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.BackColor = Color.Black;
            btnAddAlbum.ForeColor = SystemColors.ButtonHighlight;
            btnAddAlbum.Location = new Point(163, 389);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(196, 46);
            btnAddAlbum.TabIndex = 14;
            btnAddAlbum.Text = "Add Album";
            btnAddAlbum.UseVisualStyleBackColor = false;
            btnAddAlbum.Click += btnAddAlbum_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblErrorMessage.Location = new Point(6, 318);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 21);
            lblErrorMessage.TabIndex = 13;
            // 
            // rdIsNotSale
            // 
            rdIsNotSale.AutoSize = true;
            rdIsNotSale.Location = new Point(264, 284);
            rdIsNotSale.Name = "rdIsNotSale";
            rdIsNotSale.Size = new Size(56, 26);
            rdIsNotSale.TabIndex = 12;
            rdIsNotSale.TabStop = true;
            rdIsNotSale.Text = "No";
            rdIsNotSale.UseVisualStyleBackColor = true;
            // 
            // rdSale
            // 
            rdSale.AutoSize = true;
            rdSale.Location = new Point(163, 286);
            rdSale.Name = "rdSale";
            rdSale.Size = new Size(63, 26);
            rdSale.TabIndex = 11;
            rdSale.TabStop = true;
            rdSale.Text = "Yes";
            rdSale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 286);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 10;
            label1.Text = "IsSale:";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(163, 229);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(196, 29);
            dtpReleaseDate.TabIndex = 9;
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Location = new Point(10, 234);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(136, 22);
            lblReleaseDate.TabIndex = 8;
            lblReleaseDate.Text = "Release Date:";
            // 
            // txtDiscountText
            // 
            txtDiscountText.Location = new Point(163, 177);
            txtDiscountText.Name = "txtDiscountText";
            txtDiscountText.Size = new Size(196, 29);
            txtDiscountText.TabIndex = 7;
            // 
            // lblDiscountRate
            // 
            lblDiscountRate.AutoSize = true;
            lblDiscountRate.Location = new Point(2, 184);
            lblDiscountRate.Name = "lblDiscountRate";
            lblDiscountRate.Size = new Size(144, 22);
            lblDiscountRate.TabIndex = 6;
            lblDiscountRate.Text = "Discount Rate:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(163, 128);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(196, 29);
            txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(76, 135);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(63, 22);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // txtArtistorGroup
            // 
            txtArtistorGroup.Location = new Point(163, 85);
            txtArtistorGroup.Name = "txtArtistorGroup";
            txtArtistorGroup.Size = new Size(196, 29);
            txtArtistorGroup.TabIndex = 3;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(16, 88);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(130, 22);
            lblArtist.TabIndex = 2;
            lblArtist.Text = "Artist/Group:";
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(163, 34);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(196, 29);
            txtAlbumName.TabIndex = 1;
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.Location = new Point(76, 41);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(70, 22);
            lblAlbumName.TabIndex = 0;
            lblAlbumName.Text = "Name:";
            // 
            // button1
            // 
            button1.Location = new Point(1201, 472);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 20;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1290, 643);
            Controls.Add(groupBox1);
            Name = "HomePage";
            Text = "HomePage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAlbumName;
        private TextBox txtAlbumName;
        private Label lblArtist;
        private TextBox txtArtistorGroup;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblDiscountRate;
        private Label lblReleaseDate;
        private TextBox txtDiscountText;
        private Label label1;
        private DateTimePicker dtpReleaseDate;
        private RadioButton rdIsNotSale;
        private RadioButton rdSale;
        private Label lblErrorMessage;
        private Button btnAddAlbum;
        private DataGridView dgvAlbums;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnListNotOnSale;
        private Button btnListOnSale;
        private Button button1;
        private Button btnLastTenAlbum;
        private Button btnDiscountedAlbums;
        private Button btnListAll;
    }
}