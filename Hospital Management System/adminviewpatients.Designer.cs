namespace Hospital_Management_System
{
    partial class adminviewpatients
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
            this.address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Dateofbirth = new System.Windows.Forms.Label();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.patient_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contactno = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patientpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patientname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(97, 278);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(287, 52);
            this.address.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Address :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 366);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // Dateofbirth
            // 
            this.Dateofbirth.AutoSize = true;
            this.Dateofbirth.Location = new System.Drawing.Point(12, 366);
            this.Dateofbirth.Name = "Dateofbirth";
            this.Dateofbirth.Size = new System.Drawing.Size(74, 13);
            this.Dateofbirth.TabIndex = 48;
            this.Dateofbirth.Text = "Date Of Birth :";
            // 
            // genderbox
            // 
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(110, 429);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(121, 21);
            this.genderbox.TabIndex = 47;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(33, 437);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 13);
            this.label.TabIndex = 46;
            this.label.Text = "Gender :";
            // 
            // patient_id
            // 
            this.patient_id.Location = new System.Drawing.Point(110, 72);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(100, 20);
            this.patient_id.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Contact No :";
            // 
            // contactno
            // 
            this.contactno.Location = new System.Drawing.Point(110, 240);
            this.contactno.Name = "contactno";
            this.contactno.Size = new System.Drawing.Size(100, 20);
            this.contactno.TabIndex = 42;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(110, 199);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email :";
            // 
            // patientpassword
            // 
            this.patientpassword.Location = new System.Drawing.Point(110, 151);
            this.patientpassword.Name = "patientpassword";
            this.patientpassword.Size = new System.Drawing.Size(100, 20);
            this.patientpassword.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Password :";
            // 
            // patientname
            // 
            this.patientname.Location = new System.Drawing.Point(110, 104);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(100, 20);
            this.patientname.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name :";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(156, 560);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 52;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(410, 560);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 53;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(284, 560);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 54;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "View Patient Diseases";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(730, 560);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "View Appointments";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(919, 560);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "Delete Appointments";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // adminviewpatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 626);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Dateofbirth);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.patient_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contactno);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patientpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "adminviewpatients";
            this.Text = "adminviewpatients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Dateofbirth;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox patient_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contactno;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patientname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}