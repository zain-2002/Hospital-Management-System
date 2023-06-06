namespace Hospital_Management_System
{
    partial class Patientlogin
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
            this.back = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.ppas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cppass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(499, 278);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 17;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(267, 237);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 16;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // ppas
            // 
            this.ppas.Location = new System.Drawing.Point(258, 125);
            this.ppas.Name = "ppas";
            this.ppas.Size = new System.Drawing.Size(100, 20);
            this.ppas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "PASSWORD :";
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(258, 70);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(100, 20);
            this.pid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID :";
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(221, 278);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(184, 28);
            this.signup.TabIndex = 18;
            this.signup.Text = "Donot have account Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Confirm PASSWORD :";
            // 
            // cppass
            // 
            this.cppass.Location = new System.Drawing.Point(258, 184);
            this.cppass.Name = "cppass";
            this.cppass.Size = new System.Drawing.Size(100, 20);
            this.cppass.TabIndex = 20;
            // 
            // Patientlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cppass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.back);
            this.Controls.Add(this.login);
            this.Controls.Add(this.ppas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label1);
            this.Name = "Patientlogin";
            this.Text = "Patientlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox ppas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cppass;
    }
}