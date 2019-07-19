namespace WindowsFormsApplication1
{
    partial class ChangeEmploeePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NewPasswordTEXTBOx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DonateSuccessButton = new System.Windows.Forms.Button();
            this.PasswordTextOLD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.NewPasswordTEXTBOx);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UserIDTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DonateSuccessButton);
            this.panel1.Controls.Add(this.PasswordTextOLD);
            this.panel1.Location = new System.Drawing.Point(12, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 396);
            this.panel1.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 152;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 151;
            this.label1.Text = "Welcome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Tomato;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Chartreuse;
            this.label9.Location = new System.Drawing.Point(65, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 35);
            this.label9.TabIndex = 138;
            this.label9.Text = "ChangePassword";
            // 
            // NewPasswordTEXTBOx
            // 
            this.NewPasswordTEXTBOx.Location = new System.Drawing.Point(29, 203);
            this.NewPasswordTEXTBOx.Name = "NewPasswordTEXTBOx";
            this.NewPasswordTEXTBOx.Size = new System.Drawing.Size(158, 20);
            this.NewPasswordTEXTBOx.TabIndex = 148;
            this.NewPasswordTEXTBOx.TextChanged += new System.EventHandler(this.donationIDtextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(41, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 149;
            this.label11.Text = "NewPassword";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 126;
            this.label5.Text = "UserID";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(18, 131);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(158, 20);
            this.UserIDTextBox.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(224, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 134;
            this.label7.Text = "Prev. Password";
            // 
            // DonateSuccessButton
            // 
            this.DonateSuccessButton.BackColor = System.Drawing.Color.Chartreuse;
            this.DonateSuccessButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateSuccessButton.ForeColor = System.Drawing.Color.DarkRed;
            this.DonateSuccessButton.Location = new System.Drawing.Point(202, 237);
            this.DonateSuccessButton.Name = "DonateSuccessButton";
            this.DonateSuccessButton.Size = new System.Drawing.Size(204, 32);
            this.DonateSuccessButton.TabIndex = 139;
            this.DonateSuccessButton.Text = "Confirm and LogOut";
            this.DonateSuccessButton.UseVisualStyleBackColor = false;
            this.DonateSuccessButton.Click += new System.EventHandler(this.DonateSuccessButton_Click);
            // 
            // PasswordTextOLD
            // 
            this.PasswordTextOLD.Location = new System.Drawing.Point(212, 131);
            this.PasswordTextOLD.Name = "PasswordTextOLD";
            this.PasswordTextOLD.Size = new System.Drawing.Size(163, 20);
            this.PasswordTextOLD.TabIndex = 130;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 153;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ChangeEmploeePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 388);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeEmploeePassword";
            this.Text = "ChangeEmploeePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NewPasswordTEXTBOx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DonateSuccessButton;
        private System.Windows.Forms.TextBox PasswordTextOLD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}