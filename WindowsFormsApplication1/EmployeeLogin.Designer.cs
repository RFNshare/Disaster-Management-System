namespace WindowsFormsApplication1
{
    partial class EmployeeLogin
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
            this.EmpLoginPassbox = new System.Windows.Forms.TextBox();
            this.EmpLogintextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmpLoginPassbox
            // 
            this.EmpLoginPassbox.Location = new System.Drawing.Point(233, 169);
            this.EmpLoginPassbox.Name = "EmpLoginPassbox";
            this.EmpLoginPassbox.PasswordChar = '#';
            this.EmpLoginPassbox.Size = new System.Drawing.Size(144, 20);
            this.EmpLoginPassbox.TabIndex = 15;
            // 
            // EmpLogintextBox1
            // 
            this.EmpLogintextBox1.Location = new System.Drawing.Point(233, 115);
            this.EmpLogintextBox1.Name = "EmpLogintextBox1";
            this.EmpLogintextBox1.Size = new System.Drawing.Size(144, 20);
            this.EmpLogintextBox1.TabIndex = 14;
            this.EmpLogintextBox1.TextChanged += new System.EventHandler(this.EmpLogintextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employeeid";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(424, 238);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(106, 33);
            this.backbutton.TabIndex = 19;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(278, 238);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(95, 33);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(616, 353);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpLoginPassbox);
            this.Controls.Add(this.EmpLogintextBox1);
            this.Controls.Add(this.label3);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmpLoginPassbox;
        private System.Windows.Forms.TextBox EmpLogintextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button LoginButton;
    }
}