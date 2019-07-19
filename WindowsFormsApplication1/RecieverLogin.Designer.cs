namespace WindowsFormsApplication1
{
    partial class RecieverLogin
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.RecieverLoginPassbox = new System.Windows.Forms.TextBox();
            this.RecieverLogintextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DonarRegButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(461, 258);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(106, 33);
            this.backbutton.TabIndex = 27;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(315, 258);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(95, 33);
            this.LoginButton.TabIndex = 26;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RecieverLoginPassbox
            // 
            this.RecieverLoginPassbox.Location = new System.Drawing.Point(264, 188);
            this.RecieverLoginPassbox.Name = "RecieverLoginPassbox";
            this.RecieverLoginPassbox.PasswordChar = '#';
            this.RecieverLoginPassbox.Size = new System.Drawing.Size(144, 20);
            this.RecieverLoginPassbox.TabIndex = 25;
            // 
            // RecieverLogintextBox1
            // 
            this.RecieverLogintextBox1.Location = new System.Drawing.Point(264, 134);
            this.RecieverLogintextBox1.Name = "RecieverLogintextBox1";
            this.RecieverLogintextBox1.Size = new System.Drawing.Size(144, 20);
            this.RecieverLogintextBox1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Recieverid";
            // 
            // DonarRegButton
            // 
            this.DonarRegButton.Location = new System.Drawing.Point(540, 25);
            this.DonarRegButton.Name = "DonarRegButton";
            this.DonarRegButton.Size = new System.Drawing.Size(106, 33);
            this.DonarRegButton.TabIndex = 21;
            this.DonarRegButton.Text = "Register";
            this.DonarRegButton.UseVisualStyleBackColor = true;
            this.DonarRegButton.Click += new System.EventHandler(this.RecieverReg_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "NotRegistered?";
            // 
            // RecieverLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 374);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RecieverLoginPassbox);
            this.Controls.Add(this.RecieverLogintextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DonarRegButton);
            this.Controls.Add(this.label1);
            this.Name = "RecieverLogin";
            this.Text = "RecieverLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox RecieverLoginPassbox;
        private System.Windows.Forms.TextBox RecieverLogintextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DonarRegButton;
        private System.Windows.Forms.Label label1;
    }
}