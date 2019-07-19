namespace WindowsFormsApplication1
{
    partial class DonarLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.DonarRegButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DonarLogintextBox1 = new System.Windows.Forms.TextBox();
            this.DonarLoginPassbox = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NotRegistered?";
            // 
            // DonarRegButton
            // 
            this.DonarRegButton.Location = new System.Drawing.Point(485, 25);
            this.DonarRegButton.Name = "DonarRegButton";
            this.DonarRegButton.Size = new System.Drawing.Size(106, 33);
            this.DonarRegButton.TabIndex = 3;
            this.DonarRegButton.Text = "Register";
            this.DonarRegButton.UseVisualStyleBackColor = true;
            this.DonarRegButton.Click += new System.EventHandler(this.DonarRegButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "userid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "password";
            // 
            // DonarLogintextBox1
            // 
            this.DonarLogintextBox1.Location = new System.Drawing.Point(190, 124);
            this.DonarLogintextBox1.Name = "DonarLogintextBox1";
            this.DonarLogintextBox1.Size = new System.Drawing.Size(144, 20);
            this.DonarLogintextBox1.TabIndex = 6;
            // 
            // DonarLoginPassbox
            // 
            this.DonarLoginPassbox.Location = new System.Drawing.Point(190, 178);
            this.DonarLoginPassbox.Name = "DonarLoginPassbox";
            this.DonarLoginPassbox.PasswordChar = '#';
            this.DonarLoginPassbox.Size = new System.Drawing.Size(144, 20);
            this.DonarLoginPassbox.TabIndex = 7;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(387, 248);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(106, 33);
            this.backbutton.TabIndex = 19;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(241, 248);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(95, 33);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // DonarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(649, 374);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.DonarLoginPassbox);
            this.Controls.Add(this.DonarLogintextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DonarRegButton);
            this.Controls.Add(this.label1);
            this.Name = "DonarLogin";
            this.Text = "DonarLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DonarRegButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DonarLogintextBox1;
        private System.Windows.Forms.TextBox DonarLoginPassbox;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button LoginButton;
    }
}