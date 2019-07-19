namespace WindowsFormsApplication1
{
    partial class RecieverRegForm
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
            this.backbutton = new System.Windows.Forms.Button();
            this.RecieverphonenotextBox5 = new System.Windows.Forms.TextBox();
            this.recieverAdressTextBox4 = new System.Windows.Forms.TextBox();
            this.recieverPasswordtextBox3 = new System.Windows.Forms.TextBox();
            this.RecieverNametextBox2 = new System.Windows.Forms.TextBox();
            this.RecieverRegtextBox1 = new System.Windows.Forms.TextBox();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.userphoneLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UseridLabel = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(655, 381);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(138, 27);
            this.backbutton.TabIndex = 37;
            this.backbutton.Text = "back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // RecieverphonenotextBox5
            // 
            this.RecieverphonenotextBox5.Location = new System.Drawing.Point(209, 303);
            this.RecieverphonenotextBox5.Name = "RecieverphonenotextBox5";
            this.RecieverphonenotextBox5.Size = new System.Drawing.Size(211, 20);
            this.RecieverphonenotextBox5.TabIndex = 36;
            // 
            // recieverAdressTextBox4
            // 
            this.recieverAdressTextBox4.Location = new System.Drawing.Point(209, 234);
            this.recieverAdressTextBox4.Name = "recieverAdressTextBox4";
            this.recieverAdressTextBox4.Size = new System.Drawing.Size(211, 20);
            this.recieverAdressTextBox4.TabIndex = 35;
            // 
            // recieverPasswordtextBox3
            // 
            this.recieverPasswordtextBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.recieverPasswordtextBox3.Location = new System.Drawing.Point(209, 179);
            this.recieverPasswordtextBox3.Name = "recieverPasswordtextBox3";
            this.recieverPasswordtextBox3.PasswordChar = '.';
            this.recieverPasswordtextBox3.Size = new System.Drawing.Size(211, 20);
            this.recieverPasswordtextBox3.TabIndex = 34;
            // 
            // RecieverNametextBox2
            // 
            this.RecieverNametextBox2.Location = new System.Drawing.Point(209, 118);
            this.RecieverNametextBox2.Name = "RecieverNametextBox2";
            this.RecieverNametextBox2.Size = new System.Drawing.Size(211, 20);
            this.RecieverNametextBox2.TabIndex = 33;
            // 
            // RecieverRegtextBox1
            // 
            this.RecieverRegtextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RecieverRegtextBox1.Location = new System.Drawing.Point(209, 59);
            this.RecieverRegtextBox1.Name = "RecieverRegtextBox1";
            this.RecieverRegtextBox1.Size = new System.Drawing.Size(211, 20);
            this.RecieverRegtextBox1.TabIndex = 32;
            // 
            // confirmbutton
            // 
            this.confirmbutton.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.Location = new System.Drawing.Point(293, 381);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(140, 27);
            this.confirmbutton.TabIndex = 31;
            this.confirmbutton.Text = "confirm";
            this.confirmbutton.UseVisualStyleBackColor = true;
            // 
            // userphoneLabel
            // 
            this.userphoneLabel.AutoSize = true;
            this.userphoneLabel.Location = new System.Drawing.Point(131, 306);
            this.userphoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userphoneLabel.Name = "userphoneLabel";
            this.userphoneLabel.Size = new System.Drawing.Size(51, 13);
            this.userphoneLabel.TabIndex = 30;
            this.userphoneLabel.Text = "phoneNo";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(143, 237);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(39, 13);
            this.AreaLabel.TabIndex = 29;
            this.AreaLabel.Text = "Adress";
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(131, 182);
            this.UserPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(52, 13);
            this.UserPasswordLabel.TabIndex = 28;
            this.UserPasswordLabel.Text = "password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(147, 125);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(35, 13);
            this.UserNameLabel.TabIndex = 27;
            this.UserNameLabel.Text = "Name";
            // 
            // UseridLabel
            // 
            this.UseridLabel.AutoSize = true;
            this.UseridLabel.Location = new System.Drawing.Point(130, 59);
            this.UseridLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UseridLabel.Name = "UseridLabel";
            this.UseridLabel.Size = new System.Drawing.Size(61, 13);
            this.UseridLabel.TabIndex = 26;
            this.UseridLabel.Text = "RecieverID";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(494, 381);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(137, 27);
            this.exitbutton.TabIndex = 38;
            this.exitbutton.Text = "update";
            this.exitbutton.UseVisualStyleBackColor = true;
            // 
            // RecieverRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(824, 468);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.RecieverphonenotextBox5);
            this.Controls.Add(this.recieverAdressTextBox4);
            this.Controls.Add(this.recieverPasswordtextBox3);
            this.Controls.Add(this.RecieverNametextBox2);
            this.Controls.Add(this.RecieverRegtextBox1);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.userphoneLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UseridLabel);
            this.Name = "RecieverRegForm";
            this.Text = "RecieverRegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox RecieverphonenotextBox5;
        private System.Windows.Forms.TextBox recieverAdressTextBox4;
        private System.Windows.Forms.TextBox recieverPasswordtextBox3;
        private System.Windows.Forms.TextBox RecieverNametextBox2;
        private System.Windows.Forms.TextBox RecieverRegtextBox1;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Label userphoneLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UseridLabel;
        private System.Windows.Forms.Button exitbutton;
    }
}