namespace Hospital_Management_System
{
    partial class patient_patientdiseases
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
            this.viewtreatment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.FlatAppearance.BorderSize = 2;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(535, 444);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(102, 37);
            this.back.TabIndex = 5;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // viewtreatment
            // 
            this.viewtreatment.BackColor = System.Drawing.Color.Black;
            this.viewtreatment.FlatAppearance.BorderSize = 2;
            this.viewtreatment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.viewtreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewtreatment.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewtreatment.Location = new System.Drawing.Point(285, 444);
            this.viewtreatment.Name = "viewtreatment";
            this.viewtreatment.Size = new System.Drawing.Size(220, 37);
            this.viewtreatment.TabIndex = 4;
            this.viewtreatment.Text = "VIEW TREATMENT";
            this.viewtreatment.UseVisualStyleBackColor = false;
            this.viewtreatment.Click += new System.EventHandler(this.viewtreatment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 376);
            this.dataGridView1.TabIndex = 3;
            // 
            // patient_patientdiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(922, 506);
            this.Controls.Add(this.back);
            this.Controls.Add(this.viewtreatment);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "patient_patientdiseases";
            this.Text = "patient_patientdiseases";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button viewtreatment;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}