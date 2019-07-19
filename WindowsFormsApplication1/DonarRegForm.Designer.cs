namespace WindowsFormsApplication1
{
    partial class DonarRegForm
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
            this.exitbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.DonarphonenotextBox5 = new System.Windows.Forms.TextBox();
            this.DonarProjectTextBox4 = new System.Windows.Forms.TextBox();
            this.donarPasswordtextBox3 = new System.Windows.Forms.TextBox();
            this.donarNametextBox2 = new System.Windows.Forms.TextBox();
            this.DonarRegtextBox1 = new System.Windows.Forms.TextBox();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.userphoneLabel = new System.Windows.Forms.Label();
            this.UserAreaLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UseridLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(501, 413);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(129, 27);
            this.exitbutton.TabIndex = 26;
            this.exitbutton.Text = "update";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(535, 338);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(131, 27);
            this.backbutton.TabIndex = 25;
            this.backbutton.Text = "back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // DonarphonenotextBox5
            // 
            this.DonarphonenotextBox5.Location = new System.Drawing.Point(192, 335);
            this.DonarphonenotextBox5.Name = "DonarphonenotextBox5";
            this.DonarphonenotextBox5.Size = new System.Drawing.Size(211, 20);
            this.DonarphonenotextBox5.TabIndex = 24;
            // 
            // DonarProjectTextBox4
            // 
            this.DonarProjectTextBox4.Location = new System.Drawing.Point(192, 266);
            this.DonarProjectTextBox4.Name = "DonarProjectTextBox4";
            this.DonarProjectTextBox4.Size = new System.Drawing.Size(211, 20);
            this.DonarProjectTextBox4.TabIndex = 23;
            // 
            // donarPasswordtextBox3
            // 
            this.donarPasswordtextBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.donarPasswordtextBox3.Location = new System.Drawing.Point(192, 211);
            this.donarPasswordtextBox3.Name = "donarPasswordtextBox3";
            this.donarPasswordtextBox3.PasswordChar = '.';
            this.donarPasswordtextBox3.Size = new System.Drawing.Size(211, 20);
            this.donarPasswordtextBox3.TabIndex = 22;
            // 
            // donarNametextBox2
            // 
            this.donarNametextBox2.Location = new System.Drawing.Point(192, 150);
            this.donarNametextBox2.Name = "donarNametextBox2";
            this.donarNametextBox2.Size = new System.Drawing.Size(211, 20);
            this.donarNametextBox2.TabIndex = 21;
            // 
            // DonarRegtextBox1
            // 
            this.DonarRegtextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DonarRegtextBox1.Location = new System.Drawing.Point(192, 91);
            this.DonarRegtextBox1.Name = "DonarRegtextBox1";
            this.DonarRegtextBox1.Size = new System.Drawing.Size(211, 20);
            this.DonarRegtextBox1.TabIndex = 20;
            // 
            // confirmbutton
            // 
            this.confirmbutton.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton.Location = new System.Drawing.Point(298, 413);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(127, 27);
            this.confirmbutton.TabIndex = 19;
            this.confirmbutton.Text = "confirm";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // userphoneLabel
            // 
            this.userphoneLabel.AutoSize = true;
            this.userphoneLabel.Location = new System.Drawing.Point(101, 338);
            this.userphoneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userphoneLabel.Name = "userphoneLabel";
            this.userphoneLabel.Size = new System.Drawing.Size(51, 13);
            this.userphoneLabel.TabIndex = 18;
            this.userphoneLabel.Text = "phoneNo";
            // 
            // UserAreaLabel
            // 
            this.UserAreaLabel.AutoSize = true;
            this.UserAreaLabel.Location = new System.Drawing.Point(93, 273);
            this.UserAreaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserAreaLabel.Name = "UserAreaLabel";
            this.UserAreaLabel.Size = new System.Drawing.Size(66, 13);
            this.UserAreaLabel.TabIndex = 17;
            this.UserAreaLabel.Text = "Organization";
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(100, 214);
            this.UserPasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(52, 13);
            this.UserPasswordLabel.TabIndex = 16;
            this.UserPasswordLabel.Text = "password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(113, 157);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(35, 13);
            this.UserNameLabel.TabIndex = 15;
            this.UserNameLabel.Text = "Name";
            // 
            // UseridLabel
            // 
            this.UseridLabel.AutoSize = true;
            this.UseridLabel.Location = new System.Drawing.Point(113, 91);
            this.UseridLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UseridLabel.Name = "UseridLabel";
            this.UseridLabel.Size = new System.Drawing.Size(47, 13);
            this.UseridLabel.TabIndex = 14;
            this.UseridLabel.Text = "DonarID";
            // 
            // DonarRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(734, 535);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.DonarphonenotextBox5);
            this.Controls.Add(this.DonarProjectTextBox4);
            this.Controls.Add(this.donarPasswordtextBox3);
            this.Controls.Add(this.donarNametextBox2);
            this.Controls.Add(this.DonarRegtextBox1);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.userphoneLabel);
            this.Controls.Add(this.UserAreaLabel);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UseridLabel);
            this.Name = "DonarRegForm";
            this.Text = "DonarRegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox DonarphonenotextBox5;
        private System.Windows.Forms.TextBox DonarProjectTextBox4;
        private System.Windows.Forms.TextBox donarPasswordtextBox3;
        private System.Windows.Forms.TextBox donarNametextBox2;
        private System.Windows.Forms.TextBox DonarRegtextBox1;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Label userphoneLabel;
        private System.Windows.Forms.Label UserAreaLabel;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UseridLabel;
    }
}