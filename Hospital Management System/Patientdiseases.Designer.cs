using System;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    partial class Patientdiseases
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewtreatment = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewtreatment
            // 
            this.viewtreatment.BackColor = System.Drawing.Color.Black;
            this.viewtreatment.FlatAppearance.BorderSize = 2;
            this.viewtreatment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.viewtreatment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewtreatment.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewtreatment.Location = new System.Drawing.Point(231, 480);
            this.viewtreatment.Name = "viewtreatment";
            this.viewtreatment.Size = new System.Drawing.Size(249, 46);
            this.viewtreatment.TabIndex = 1;
            this.viewtreatment.Text = "VIEW TREATMENT";
            this.viewtreatment.UseVisualStyleBackColor = false;
            this.viewtreatment.Click += new System.EventHandler(this.viewtreatment_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.FlatAppearance.BorderSize = 2;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(529, 478);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 46);
            this.back.TabIndex = 2;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Patientdiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1060, 538);
            this.Controls.Add(this.back);
            this.Controls.Add(this.viewtreatment);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Patientdiseases";
            this.Text = "Patientdiseases";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewtreatment;
        private System.Windows.Forms.Button back;
    }
}