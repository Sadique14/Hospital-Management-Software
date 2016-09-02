namespace Hospital_Management
{
    partial class Admin
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
            this.name = new System.Windows.Forms.Label();
            this.patientSerial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diseaseLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ageOfDLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.illnessLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.familyLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.previusLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.doctorBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.postponeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(32, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Patient:";
            // 
            // patientSerial
            // 
            this.patientSerial.Font = new System.Drawing.Font("Siyam Rupali", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSerial.FormattingEnabled = true;
            this.patientSerial.Location = new System.Drawing.Point(92, 21);
            this.patientSerial.Name = "patientSerial";
            this.patientSerial.Size = new System.Drawing.Size(170, 25);
            this.patientSerial.TabIndex = 1;
            this.patientSerial.SelectedIndexChanged += new System.EventHandler(this.patientSerial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Of Birth:";
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birth.Location = new System.Drawing.Point(130, 66);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(81, 19);
            this.birth.TabIndex = 3;
            this.birth.Text = "Date Of Birth";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sexLabel.Location = new System.Drawing.Point(130, 98);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(81, 19);
            this.sexLabel.TabIndex = 5;
            this.sexLabel.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sex:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addressLabel.Location = new System.Drawing.Point(130, 130);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 19);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adress:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contactLabel.Location = new System.Drawing.Point(130, 161);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(81, 19);
            this.contactLabel.TabIndex = 9;
            this.contactLabel.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact No:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(130, 192);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(81, 19);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // diseaseLabel
            // 
            this.diseaseLabel.AutoSize = true;
            this.diseaseLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diseaseLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.diseaseLabel.Location = new System.Drawing.Point(407, 66);
            this.diseaseLabel.Name = "diseaseLabel";
            this.diseaseLabel.Size = new System.Drawing.Size(81, 19);
            this.diseaseLabel.TabIndex = 13;
            this.diseaseLabel.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Disease:";
            // 
            // ageOfDLabel
            // 
            this.ageOfDLabel.AutoSize = true;
            this.ageOfDLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageOfDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ageOfDLabel.Location = new System.Drawing.Point(130, 222);
            this.ageOfDLabel.Name = "ageOfDLabel";
            this.ageOfDLabel.Size = new System.Drawing.Size(81, 19);
            this.ageOfDLabel.TabIndex = 15;
            this.ageOfDLabel.Text = "Date Of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Age Of Disease:";
            // 
            // illnessLabel
            // 
            this.illnessLabel.AutoSize = true;
            this.illnessLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illnessLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.illnessLabel.Location = new System.Drawing.Point(130, 283);
            this.illnessLabel.Name = "illnessLabel";
            this.illnessLabel.Size = new System.Drawing.Size(81, 19);
            this.illnessLabel.TabIndex = 17;
            this.illnessLabel.Text = "Date Of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Illness:";
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familyLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.familyLabel.Location = new System.Drawing.Point(130, 383);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(81, 19);
            this.familyLabel.TabIndex = 19;
            this.familyLabel.Text = "Date Of Birth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Family History:";
            // 
            // previusLabel
            // 
            this.previusLabel.AutoSize = true;
            this.previusLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.previusLabel.Location = new System.Drawing.Point(134, 479);
            this.previusLabel.Name = "previusLabel";
            this.previusLabel.Size = new System.Drawing.Size(81, 19);
            this.previusLabel.TabIndex = 21;
            this.previusLabel.Text = "Date Of Birth";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 478);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Previous Visit:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.doctorLabel.Location = new System.Drawing.Point(424, 98);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(81, 19);
            this.doctorLabel.TabIndex = 23;
            this.doctorLabel.Text = "Date Of Birth";
            this.doctorLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Prefered Doctor:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Siyam Rupali", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.departmentLabel.Location = new System.Drawing.Point(622, 98);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(81, 19);
            this.departmentLabel.TabIndex = 25;
            this.departmentLabel.Text = "Date Of Birth";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(533, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Department:";
            // 
            // doctorBox
            // 
            this.doctorBox.Font = new System.Drawing.Font("Siyam Rupali", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorBox.FormattingEnabled = true;
            this.doctorBox.Location = new System.Drawing.Point(749, 261);
            this.doctorBox.Name = "doctorBox";
            this.doctorBox.Size = new System.Drawing.Size(170, 25);
            this.doctorBox.TabIndex = 27;
            this.doctorBox.SelectedIndexChanged += new System.EventHandler(this.doctorBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Select Assigned Doctor:";
            // 
            // postponeButton
            // 
            this.postponeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postponeButton.Location = new System.Drawing.Point(313, 141);
            this.postponeButton.Name = "postponeButton";
            this.postponeButton.Size = new System.Drawing.Size(83, 29);
            this.postponeButton.TabIndex = 28;
            this.postponeButton.Text = "Postpone";
            this.postponeButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Location = new System.Drawing.Point(411, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 29);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(309, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Select Department:";
            // 
            // departmentBox
            // 
            this.departmentBox.Font = new System.Drawing.Font("Siyam Rupali", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Items.AddRange(new object[] {
            "<none>",
            "Cardiology",
            "Clinical Psychology",
            "Dental",
            "Emergency Consultation",
            "General Surgery",
            "Internal Medicine",
            "Gynecology",
            "Oncology",
            "Respiratory Medicine",
            "Skin",
            "Urology"});
            this.departmentBox.Location = new System.Drawing.Point(437, 261);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(125, 25);
            this.departmentBox.TabIndex = 31;
            this.departmentBox.SelectedIndexChanged += new System.EventHandler(this.departmentBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Siyam Rupali", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(309, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Message:";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(381, 333);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(538, 69);
            this.messageBox.TabIndex = 33;
            // 
            // assignButton
            // 
            this.assignButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.assignButton.Location = new System.Drawing.Point(313, 442);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(162, 44);
            this.assignButton.TabIndex = 34;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(747, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 27);
            this.button2.TabIndex = 35;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(836, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 27);
            this.button3.TabIndex = 36;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 526);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.postponeButton);
            this.Controls.Add(this.doctorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.previusLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.familyLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.illnessLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ageOfDLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.diseaseLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientSerial);
            this.Controls.Add(this.name);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox patientSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label diseaseLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ageOfDLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label illnessLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label familyLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label previusLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox doctorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button postponeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}