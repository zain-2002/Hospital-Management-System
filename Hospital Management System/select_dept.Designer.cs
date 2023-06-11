namespace Hospital_Management_System
{
    partial class select_dept
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
            this.gyna = new System.Windows.Forms.Button();
            this.neuro = new System.Windows.Forms.Button();
            this.ortho = new System.Windows.Forms.Button();
            this.cardiac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gyna
            // 
            this.gyna.Location = new System.Drawing.Point(109, 150);
            this.gyna.Name = "gyna";
            this.gyna.Size = new System.Drawing.Size(75, 23);
            this.gyna.TabIndex = 0;
            this.gyna.Text = "Gyna";
            this.gyna.UseVisualStyleBackColor = true;
            this.gyna.Click += new System.EventHandler(this.button1_Click);
            // 
            // neuro
            // 
            this.neuro.Location = new System.Drawing.Point(109, 236);
            this.neuro.Name = "neuro";
            this.neuro.Size = new System.Drawing.Size(75, 23);
            this.neuro.TabIndex = 1;
            this.neuro.Text = "Neuro";
            this.neuro.UseVisualStyleBackColor = true;
            this.neuro.Click += new System.EventHandler(this.neuro_Click);
            // 
            // ortho
            // 
            this.ortho.Location = new System.Drawing.Point(109, 282);
            this.ortho.Name = "ortho";
            this.ortho.Size = new System.Drawing.Size(75, 23);
            this.ortho.TabIndex = 2;
            this.ortho.Text = "Ortho";
            this.ortho.UseVisualStyleBackColor = true;
            this.ortho.Click += new System.EventHandler(this.ortho_Click);
            // 
            // cardiac
            // 
            this.cardiac.Location = new System.Drawing.Point(109, 189);
            this.cardiac.Name = "cardiac";
            this.cardiac.Size = new System.Drawing.Size(75, 27);
            this.cardiac.TabIndex = 3;
            this.cardiac.Text = "Cardiac";
            this.cardiac.UseVisualStyleBackColor = true;
            this.cardiac.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Department";
            // 
            // select_dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardiac);
            this.Controls.Add(this.ortho);
            this.Controls.Add(this.neuro);
            this.Controls.Add(this.gyna);
            this.Name = "select_dept";
            this.Text = "make_appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gyna;
        private System.Windows.Forms.Button neuro;
        private System.Windows.Forms.Button ortho;
        private System.Windows.Forms.Button cardiac;
        private System.Windows.Forms.Label label1;
    }
}