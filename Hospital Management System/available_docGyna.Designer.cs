namespace Hospital_Management_System
{
    partial class available_docGyna
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
            this.from = new System.Windows.Forms.DateTimePicker();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diseasename = new System.Windows.Forms.Label();
            this.diseasen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(12, 132);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(144, 20);
            this.from.TabIndex = 22;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(239, 132);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(127, 20);
            this.to.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(86, 253);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(345, 141);
            this.description.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Decsription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "selectdate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(101, 49);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 382);
            this.dataGridView1.TabIndex = 13;
            // 
            // diseasename
            // 
            this.diseasename.AutoSize = true;
            this.diseasename.Location = new System.Drawing.Point(9, 200);
            this.diseasename.Name = "diseasename";
            this.diseasename.Size = new System.Drawing.Size(50, 13);
            this.diseasename.TabIndex = 23;
            this.diseasename.Text = "Diseases\r\n";
            // 
            // diseasen
            // 
            this.diseasen.Location = new System.Drawing.Point(74, 197);
            this.diseasen.Name = "diseasen";
            this.diseasen.Size = new System.Drawing.Size(154, 20);
            this.diseasen.TabIndex = 24;
            // 
            // available_docGyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.diseasen);
            this.Controls.Add(this.diseasename);
            this.Controls.Add(this.from);
            this.Controls.Add(this.to);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dataGridView1);
            this.Name = "available_docGyna";
            this.Text = "available_docGyna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.available_docGyna_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label diseasename;
        private System.Windows.Forms.TextBox diseasen;
    }
}