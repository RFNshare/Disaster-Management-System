namespace WindowsFormsApplication1
{
    partial class AdminPanelLogin
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
            this.AdminLoginPassbox = new System.Windows.Forms.TextBox();
            this.AdminLogintextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminLoginPassbox
            // 
            this.AdminLoginPassbox.Location = new System.Drawing.Point(208, 181);
            this.AdminLoginPassbox.Name = "AdminLoginPassbox";
            this.AdminLoginPassbox.PasswordChar = '#';
            this.AdminLoginPassbox.Size = new System.Drawing.Size(144, 20);
            this.AdminLoginPassbox.TabIndex = 21;
            // 
            // AdminLogintextBox1
            // 
            this.AdminLogintextBox1.Location = new System.Drawing.Point(208, 127);
            this.AdminLogintextBox1.Name = "AdminLogintextBox1";
            this.AdminLogintextBox1.Size = new System.Drawing.Size(144, 20);
            this.AdminLogintextBox1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "AdminId";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(414, 239);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(106, 33);
            this.backbutton.TabIndex = 17;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(268, 239);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(95, 33);
            this.LoginButton.TabIndex = 16;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AdminPanelLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 399);
            this.Controls.Add(this.AdminLoginPassbox);
            this.Controls.Add(this.AdminLogintextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.LoginButton);
            this.Name = "AdminPanelLogin";
            this.Text = "AdminPanelLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminLoginPassbox;
        private System.Windows.Forms.TextBox AdminLogintextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button LoginButton;
    }
}