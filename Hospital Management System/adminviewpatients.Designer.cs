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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(732, 390);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.Black;
            this.address.Font = new System.Drawing.Font("MV Boli", 9F);
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(156, 245);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 94);
            this.address.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(53, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 50;
            this.label7.Text = "Address :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 354);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // Dateofbirth
            // 
            this.Dateofbirth.AutoSize = true;
            this.Dateofbirth.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.Dateofbirth.ForeColor = System.Drawing.Color.White;
            this.Dateofbirth.Location = new System.Drawing.Point(11, 354);
            this.Dateofbirth.Name = "Dateofbirth";
            this.Dateofbirth.Size = new System.Drawing.Size(145, 21);
            this.Dateofbirth.TabIndex = 48;
            this.Dateofbirth.Text = "Date Of Birth :";
            // 
            // genderbox
            // 
            this.genderbox.BackColor = System.Drawing.Color.Black;
            this.genderbox.Font = new System.Drawing.Font("MV Boli", 9F);
            this.genderbox.ForeColor = System.Drawing.Color.White;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(156, 388);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(200, 25);
            this.genderbox.TabIndex = 47;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(72, 385);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 21);
            this.label.TabIndex = 46;
            this.label.Text = "Gender :";
            // 
            // patient_id
            // 
            this.patient_id.BackColor = System.Drawing.Color.Black;
            this.patient_id.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_id.ForeColor = System.Drawing.Color.White;
            this.patient_id.Location = new System.Drawing.Point(156, 76);
            this.patient_id.Name = "patient_id";
            this.patient_id.Size = new System.Drawing.Size(200, 27);
            this.patient_id.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Contact No :";
            // 
            // contactno
            // 
            this.contactno.BackColor = System.Drawing.Color.Black;
            this.contactno.Font = new System.Drawing.Font("MV Boli", 9F);
            this.contactno.ForeColor = System.Drawing.Color.White;
            this.contactno.Location = new System.Drawing.Point(156, 213);
            this.contactno.Name = "contactno";
            this.contactno.Size = new System.Drawing.Size(200, 27);
            this.contactno.TabIndex = 42;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Black;
            this.email.Font = new System.Drawing.Font("MV Boli", 9F);
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(156, 180);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 27);
            this.email.TabIndex = 41;
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email :";
            // 
            // patientpassword
            // 
            this.patientpassword.BackColor = System.Drawing.Color.Black;
            this.patientpassword.Font = new System.Drawing.Font("MV Boli", 9F);
            this.patientpassword.ForeColor = System.Drawing.Color.White;
            this.patientpassword.Location = new System.Drawing.Point(156, 143);
            this.patientpassword.Name = "patientpassword";
            this.patientpassword.Size = new System.Drawing.Size(200, 27);
            this.patientpassword.TabIndex = 37;
            this.patientpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Password :";
            // 
            // patientname
            // 
            this.patientname.BackColor = System.Drawing.Color.Black;
            this.patientname.Font = new System.Drawing.Font("MV Boli", 9F);
            this.patientname.ForeColor = System.Drawing.Color.White;
            this.patientname.Location = new System.Drawing.Point(156, 109);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(200, 27);
            this.patientname.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name :";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.FlatAppearance.BorderSize = 2;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(156, 479);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(84, 36);
            this.add.TabIndex = 52;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Black;
            this.delete.FlatAppearance.BorderSize = 2;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(387, 479);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(99, 36);
            this.delete.TabIndex = 53;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.FlatAppearance.BorderSize = 2;
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(260, 479);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(111, 36);
            this.update.TabIndex = 54;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(492, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 36);
            this.button1.TabIndex = 55;
            this.button1.Text = "View Patient Diseases";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(733, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 56;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // adminviewpatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1100, 544);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}