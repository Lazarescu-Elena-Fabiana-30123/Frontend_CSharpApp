
namespace Proiect_SCD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeListComboBox = new System.Windows.Forms.ComboBox();
            this.loadEmployees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.addEmployee = new System.Windows.Forms.Button();
            this.departmentsComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.TextBox();
            this.deptIDLabel = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.managerLabel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EnrollDateLabel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.departmentName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxManager = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.loadDeptEmployees = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.managertxt1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.parentIDtxt = new System.Windows.Forms.TextBox();
            this.nameDepartment = new System.Windows.Forms.TextBox();
            this.deptID = new System.Windows.Forms.TextBox();
            this.DepartmentID = new System.Windows.Forms.Label();
            this.textBoxParentID = new System.Windows.Forms.TextBox();
            this.managerComboBox = new System.Windows.Forms.ComboBox();
            this.addDepartment = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.deleteDepartment = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.loadDepartments = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeListComboBox
            // 
            this.employeeListComboBox.FormattingEnabled = true;
            this.employeeListComboBox.Location = new System.Drawing.Point(12, 73);
            this.employeeListComboBox.Name = "employeeListComboBox";
            this.employeeListComboBox.Size = new System.Drawing.Size(128, 28);
            this.employeeListComboBox.TabIndex = 0;
            this.employeeListComboBox.SelectedValueChanged += new System.EventHandler(this.employeeListComboBox_SelectedValueChanged);
            // 
            // loadEmployees
            // 
            this.loadEmployees.Location = new System.Drawing.Point(287, 37);
            this.loadEmployees.Name = "loadEmployees";
            this.loadEmployees.Size = new System.Drawing.Size(150, 29);
            this.loadEmployees.TabIndex = 1;
            this.loadEmployees.Text = "Load Employees";
            this.loadEmployees.UseVisualStyleBackColor = true;
            this.loadEmployees.Click += new System.EventHandler(this.loadEmployees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees";
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Location = new System.Drawing.Point(287, 98);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(149, 29);
            this.deleteEmployee.TabIndex = 3;
            this.deleteEmployee.Text = "Delete employee";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(559, 278);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(175, 27);
            this.textBox5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Manager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Employee name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(559, 73);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(175, 27);
            this.nameTxtBox.TabIndex = 14;
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(559, 328);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(149, 29);
            this.addEmployee.TabIndex = 16;
            this.addEmployee.Text = "Add employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // departmentsComboBox
            // 
            this.departmentsComboBox.FormattingEnabled = true;
            this.departmentsComboBox.Location = new System.Drawing.Point(557, 144);
            this.departmentsComboBox.Name = "departmentsComboBox";
            this.departmentsComboBox.Size = new System.Drawing.Size(177, 28);
            this.departmentsComboBox.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Employee ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // empID
            // 
            this.empID.Location = new System.Drawing.Point(13, 141);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(191, 27);
            this.empID.TabIndex = 27;
            // 
            // deptIDLabel
            // 
            this.deptIDLabel.Location = new System.Drawing.Point(15, 248);
            this.deptIDLabel.Name = "deptIDLabel";
            this.deptIDLabel.Size = new System.Drawing.Size(191, 27);
            this.deptIDLabel.TabIndex = 28;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(15, 194);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(191, 27);
            this.nameLabel.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Employee name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Department ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Manager ID";
            // 
            // managerLabel
            // 
            this.managerLabel.Location = new System.Drawing.Point(13, 300);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(191, 27);
            this.managerLabel.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Email";
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(13, 354);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(191, 27);
            this.emailLabel.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Enroll Date";
            // 
            // EnrollDateLabel
            // 
            this.EnrollDateLabel.Location = new System.Drawing.Point(13, 411);
            this.EnrollDateLabel.Name = "EnrollDateLabel";
            this.EnrollDateLabel.ReadOnly = true;
            this.EnrollDateLabel.Size = new System.Drawing.Size(191, 27);
            this.EnrollDateLabel.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Department name";
            // 
            // departmentName
            // 
            this.departmentName.Location = new System.Drawing.Point(271, 252);
            this.departmentName.Name = "departmentName";
            this.departmentName.ReadOnly = true;
            this.departmentName.Size = new System.Drawing.Size(173, 27);
            this.departmentName.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Manager name";
            // 
            // textBoxManager
            // 
            this.textBoxManager.Location = new System.Drawing.Point(271, 305);
            this.textBoxManager.Name = "textBoxManager";
            this.textBoxManager.ReadOnly = true;
            this.textBoxManager.Size = new System.Drawing.Size(173, 27);
            this.textBoxManager.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(559, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 20);
            this.label14.TabIndex = 98;
            this.label14.Text = "Department name";
            // 
            // loadDeptEmployees
            // 
            this.loadDeptEmployees.Location = new System.Drawing.Point(260, 868);
            this.loadDeptEmployees.Name = "loadDeptEmployees";
            this.loadDeptEmployees.Size = new System.Drawing.Size(150, 29);
            this.loadDeptEmployees.TabIndex = 97;
            this.loadDeptEmployees.Text = "Load employees";
            this.loadDeptEmployees.UseVisualStyleBackColor = true;
            this.loadDeptEmployees.Click += new System.EventHandler(this.loadDeptEmployees_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(263, 740);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 20);
            this.label15.TabIndex = 95;
            this.label15.Text = "Manager name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(263, 763);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(173, 27);
            this.textBox2.TabIndex = 94;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 623);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 20);
            this.label16.TabIndex = 93;
            this.label16.Text = "Department name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 740);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 20);
            this.label17.TabIndex = 92;
            this.label17.Text = "Manager ID";
            // 
            // managertxt1
            // 
            this.managertxt1.Location = new System.Drawing.Point(18, 763);
            this.managertxt1.Name = "managertxt1";
            this.managertxt1.Size = new System.Drawing.Size(191, 27);
            this.managertxt1.TabIndex = 91;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 686);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 90;
            this.label18.Text = "Parent ID";
            // 
            // parentIDtxt
            // 
            this.parentIDtxt.Location = new System.Drawing.Point(18, 709);
            this.parentIDtxt.Name = "parentIDtxt";
            this.parentIDtxt.Size = new System.Drawing.Size(191, 27);
            this.parentIDtxt.TabIndex = 89;
            // 
            // nameDepartment
            // 
            this.nameDepartment.Location = new System.Drawing.Point(18, 646);
            this.nameDepartment.Name = "nameDepartment";
            this.nameDepartment.Size = new System.Drawing.Size(191, 27);
            this.nameDepartment.TabIndex = 87;
            // 
            // deptID
            // 
            this.deptID.Location = new System.Drawing.Point(16, 593);
            this.deptID.Name = "deptID";
            this.deptID.Size = new System.Drawing.Size(191, 27);
            this.deptID.TabIndex = 85;
            // 
            // DepartmentID
            // 
            this.DepartmentID.AutoSize = true;
            this.DepartmentID.Location = new System.Drawing.Point(15, 572);
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Size = new System.Drawing.Size(108, 20);
            this.DepartmentID.TabIndex = 84;
            this.DepartmentID.Text = "Department ID";
            // 
            // textBoxParentID
            // 
            this.textBoxParentID.Location = new System.Drawing.Point(561, 595);
            this.textBoxParentID.Name = "textBoxParentID";
            this.textBoxParentID.Size = new System.Drawing.Size(175, 27);
            this.textBoxParentID.TabIndex = 83;
            // 
            // managerComboBox
            // 
            this.managerComboBox.FormattingEnabled = true;
            this.managerComboBox.Location = new System.Drawing.Point(561, 669);
            this.managerComboBox.Name = "managerComboBox";
            this.managerComboBox.Size = new System.Drawing.Size(177, 28);
            this.managerComboBox.TabIndex = 82;
            // 
            // addDepartment
            // 
            this.addDepartment.Location = new System.Drawing.Point(561, 725);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(149, 29);
            this.addDepartment.TabIndex = 81;
            this.addDepartment.Text = "Add department";
            this.addDepartment.UseVisualStyleBackColor = true;
            this.addDepartment.Click += new System.EventHandler(this.addDepartment_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(561, 524);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 27);
            this.textBox4.TabIndex = 80;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(561, 639);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 20);
            this.label20.TabIndex = 79;
            this.label20.Text = "Manager id";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(561, 572);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 20);
            this.label21.TabIndex = 78;
            this.label21.Text = "Parent ID";
            // 
            // deleteDepartment
            // 
            this.deleteDepartment.Location = new System.Drawing.Point(264, 593);
            this.deleteDepartment.Name = "deleteDepartment";
            this.deleteDepartment.Size = new System.Drawing.Size(149, 29);
            this.deleteDepartment.TabIndex = 77;
            this.deleteDepartment.Text = "Delete department";
            this.deleteDepartment.UseVisualStyleBackColor = true;
            this.deleteDepartment.Click += new System.EventHandler(this.deleteDepartment_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 480);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 20);
            this.label22.TabIndex = 76;
            this.label22.Text = "Departments";
            // 
            // loadDepartments
            // 
            this.loadDepartments.Location = new System.Drawing.Point(263, 525);
            this.loadDepartments.Name = "loadDepartments";
            this.loadDepartments.Size = new System.Drawing.Size(150, 29);
            this.loadDepartments.TabIndex = 75;
            this.loadDepartments.Text = "Load departments";
            this.loadDepartments.UseVisualStyleBackColor = true;
            this.loadDepartments.Click += new System.EventHandler(this.loadDepartments_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 525);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 28);
            this.comboBox1.TabIndex = 74;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 868);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 28);
            this.comboBox2.TabIndex = 99;
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.Location = new System.Drawing.Point(288, 153);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(149, 29);
            this.UpdateEmployee.TabIndex = 100;
            this.UpdateEmployee.Text = "Update employee";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(769, 921);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.loadDeptEmployees);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.managertxt1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.parentIDtxt);
            this.Controls.Add(this.nameDepartment);
            this.Controls.Add(this.deptID);
            this.Controls.Add(this.DepartmentID);
            this.Controls.Add(this.textBoxParentID);
            this.Controls.Add(this.managerComboBox);
            this.Controls.Add(this.addDepartment);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.deleteDepartment);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.loadDepartments);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxManager);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.departmentName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EnrollDateLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deptIDLabel);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.departmentsComboBox);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadEmployees);
            this.Controls.Add(this.employeeListComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeListComboBox;
        private System.Windows.Forms.Button loadEmployees;
        //private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.ComboBox departmentsComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.TextBox deptIDLabel;
        private System.Windows.Forms.TextBox nameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox managerLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox EnrollDateLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox departmentName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button loadDeptEmployees;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox managertxt1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox parentIDtxt;
        private System.Windows.Forms.TextBox nameDepartment;
        private System.Windows.Forms.TextBox deptID;
        private System.Windows.Forms.Label DepartmentID;
        private System.Windows.Forms.TextBox textBoxParentID;
        private System.Windows.Forms.ComboBox managerComboBox;
        private System.Windows.Forms.Button addDepartment;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button deleteDepartment;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button loadDepartments;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button UpdateEmployee;
    }
}

