namespace WindowsFormsApplication1
{
    partial class Enter1DonarForm
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.loadEmpBtn = new System.Windows.Forms.Button();
            this.projrctDataSearchTextbox = new System.Windows.Forms.TextBox();
            this.searchProjectdataBtn = new System.Windows.Forms.Button();
            this.ProjectListGridView1 = new System.Windows.Forms.DataGridView();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.AlreadyDistributedDonationGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.DonationButton = new System.Windows.Forms.Button();
            this.LoadDistributedButton = new System.Windows.Forms.Button();
            this.DistributedSearchTextbox = new System.Windows.Forms.TextBox();
            this.searchDistributeddataBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectListGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlreadyDistributedDonationGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1001, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(133, 23);
            this.logoutBtn.TabIndex = 43;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // loadEmpBtn
            // 
            this.loadEmpBtn.Location = new System.Drawing.Point(42, 329);
            this.loadEmpBtn.Name = "loadEmpBtn";
            this.loadEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.loadEmpBtn.TabIndex = 36;
            this.loadEmpBtn.Text = "Load";
            this.loadEmpBtn.UseVisualStyleBackColor = true;
            // 
            // projrctDataSearchTextbox
            // 
            this.projrctDataSearchTextbox.Location = new System.Drawing.Point(142, 332);
            this.projrctDataSearchTextbox.Name = "projrctDataSearchTextbox";
            this.projrctDataSearchTextbox.Size = new System.Drawing.Size(162, 20);
            this.projrctDataSearchTextbox.TabIndex = 35;
            // 
            // searchProjectdataBtn
            // 
            this.searchProjectdataBtn.Location = new System.Drawing.Point(323, 329);
            this.searchProjectdataBtn.Name = "searchProjectdataBtn";
            this.searchProjectdataBtn.Size = new System.Drawing.Size(88, 23);
            this.searchProjectdataBtn.TabIndex = 34;
            this.searchProjectdataBtn.Text = "Search";
            this.searchProjectdataBtn.UseVisualStyleBackColor = true;
            // 
            // ProjectListGridView1
            // 
            this.ProjectListGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.ProjectListGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectListGridView1.Location = new System.Drawing.Point(16, 68);
            this.ProjectListGridView1.Name = "ProjectListGridView1";
            this.ProjectListGridView1.Size = new System.Drawing.Size(511, 249);
            this.ProjectListGridView1.TabIndex = 28;
            this.ProjectListGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectListGridView1_CellContentClick);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(28, 45);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(350, 20);
            this.welcomeLabel.TabIndex = 27;
            this.welcomeLabel.Text = "Show ALL The enrolling  Project Data";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // AlreadyDistributedDonationGridView2
            // 
            this.AlreadyDistributedDonationGridView2.BackgroundColor = System.Drawing.Color.LightPink;
            this.AlreadyDistributedDonationGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlreadyDistributedDonationGridView2.Location = new System.Drawing.Point(727, 194);
            this.AlreadyDistributedDonationGridView2.Name = "AlreadyDistributedDonationGridView2";
            this.AlreadyDistributedDonationGridView2.Size = new System.Drawing.Size(489, 244);
            this.AlreadyDistributedDonationGridView2.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(747, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Already Distributed Donations";
            // 
            // DonationButton
            // 
            this.DonationButton.Location = new System.Drawing.Point(197, 487);
            this.DonationButton.Name = "DonationButton";
            this.DonationButton.Size = new System.Drawing.Size(184, 33);
            this.DonationButton.TabIndex = 66;
            this.DonationButton.Text = "Donation";
            this.DonationButton.UseVisualStyleBackColor = true;
            // 
            // LoadDistributedButton
            // 
            this.LoadDistributedButton.Location = new System.Drawing.Point(760, 471);
            this.LoadDistributedButton.Name = "LoadDistributedButton";
            this.LoadDistributedButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDistributedButton.TabIndex = 69;
            this.LoadDistributedButton.Text = "Load";
            this.LoadDistributedButton.UseVisualStyleBackColor = true;
            // 
            // DistributedSearchTextbox
            // 
            this.DistributedSearchTextbox.Location = new System.Drawing.Point(888, 471);
            this.DistributedSearchTextbox.Name = "DistributedSearchTextbox";
            this.DistributedSearchTextbox.Size = new System.Drawing.Size(196, 20);
            this.DistributedSearchTextbox.TabIndex = 68;
            // 
            // searchDistributeddataBtn
            // 
            this.searchDistributeddataBtn.Location = new System.Drawing.Point(1120, 469);
            this.searchDistributeddataBtn.Name = "searchDistributeddataBtn";
            this.searchDistributeddataBtn.Size = new System.Drawing.Size(75, 23);
            this.searchDistributeddataBtn.TabIndex = 67;
            this.searchDistributeddataBtn.Text = "Search";
            this.searchDistributeddataBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Start Your Donation";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(429, 487);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 33);
            this.backBtn.TabIndex = 38;
            this.backBtn.Text = "back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // Enter1DonarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1240, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadDistributedButton);
            this.Controls.Add(this.DistributedSearchTextbox);
            this.Controls.Add(this.searchDistributeddataBtn);
            this.Controls.Add(this.DonationButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AlreadyDistributedDonationGridView2);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.loadEmpBtn);
            this.Controls.Add(this.projrctDataSearchTextbox);
            this.Controls.Add(this.searchProjectdataBtn);
            this.Controls.Add(this.ProjectListGridView1);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Enter1DonarForm";
            this.Text = "Enter1DonarForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectListGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlreadyDistributedDonationGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button loadEmpBtn;
        private System.Windows.Forms.TextBox projrctDataSearchTextbox;
        private System.Windows.Forms.Button searchProjectdataBtn;
        private System.Windows.Forms.DataGridView ProjectListGridView1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DataGridView AlreadyDistributedDonationGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DonationButton;
        private System.Windows.Forms.Button LoadDistributedButton;
        private System.Windows.Forms.TextBox DistributedSearchTextbox;
        private System.Windows.Forms.Button searchDistributeddataBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
    }
}