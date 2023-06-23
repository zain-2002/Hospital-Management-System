namespace Hospital_Management_System
{
    partial class available_docNeuro
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
            this.diseasen = new System.Windows.Forms.TextBox();
            this.diseasename = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.back = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // diseasen
            // 
            this.diseasen.Location = new System.Drawing.Point(88, 197);
            this.diseasen.Name = "diseasen";
            this.diseasen.Size = new System.Drawing.Size(154, 20);
            this.diseasen.TabIndex = 36;
            // 
            // diseasename
            // 
            this.diseasename.AutoSize = true;
            this.diseasename.Location = new System.Drawing.Point(23, 200);
            this.diseasename.Name = "diseasename";
            this.diseasename.Size = new System.Drawing.Size(50, 13);
            this.diseasename.TabIndex = 35;
            this.diseasename.Text = "Diseases\r\n";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(26, 132);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(144, 20);
            this.from.TabIndex = 34;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(253, 132);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(127, 20);
            this.to.TabIndex = 33;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(465, 415);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 32;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(100, 253);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(345, 141);
            this.description.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Decsription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "selectdate";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(213, 415);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 27;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(115, 49);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 382);
            this.dataGridView1.TabIndex = 25;
            // 
            // available_docNeuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.diseasen);
            this.Controls.Add(this.diseasename);
            this.Controls.Add(this.from);
            this.Controls.Add(this.to);
            this.Controls.Add(this.back);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dataGridView1);
            this.Name = "available_docNeuro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diseasen;
        private System.Windows.Forms.Label diseasename;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}