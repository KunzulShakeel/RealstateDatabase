using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RealState_Project
{
    partial class Employee
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
            xGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            EMAIL_OF_REALSTATE = new DataGridViewTextBoxColumn();
            NO_OF_EMPLOYEE = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            SALARY = new TextBox();
            NFE = new TextBox();
            PNOFE = new TextBox();
            EOFE = new TextBox();
            AOFE = new TextBox();
            DID = new TextBox();
            EID = new TextBox();
            exitbtn = new Button();
            WONPID = new TextBox();
            nextbtn = new Button();
            viewbtn = new Button();
            Deletebtn = new Button();
            editbtn = new Button();
            savebtn = new Button();
            LABEL8 = new Label();
            LABEL7 = new Label();
            LABEL6 = new Label();
            LABEL5 = new Label();
            LABEL4 = new Label();
            LABEL3 = new Label();
            C = new Label();
            LABEL1 = new Label();
            BACKBTN = new Button();
            label2 = new Label();
            Searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)xGrid).BeginInit();
            SuspendLayout();
            // 
            // xGrid
            // 
            xGrid.AccessibleName = "";
            xGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            xGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, EMAIL_OF_REALSTATE, NO_OF_EMPLOYEE, Column8 });
            xGrid.Location = new Point(606, 89);
            xGrid.Name = "xGrid";
            xGrid.Size = new Size(840, 257);
            xGrid.TabIndex = 45;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "EMPLOYEE_ID";
            Column1.HeaderText = "EMPLOYEE ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "NAME_OF_EMPLOYEE";
            Column2.HeaderText = "NAME OF EMPLOYEE";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PHONE_NUMBER_OF_EMPLOYEE";
            Column3.HeaderText = "PHONE NUMBER OF EMPLOYEE";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "EMAIL_OF_EMPLOYEE";
            Column4.HeaderText = "EMAIL OF EMPLOYEE";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ADDRESS_OF_EMPLOYEE";
            Column5.HeaderText = "ADDRESS OF EMPLOYEE";
            Column5.Name = "Column5";
            // 
            // EMAIL_OF_REALSTATE
            // 
            EMAIL_OF_REALSTATE.DataPropertyName = "WORKING_ON_PROJECT_ID";
            EMAIL_OF_REALSTATE.HeaderText = "WORKING ON PROJECT ID";
            EMAIL_OF_REALSTATE.Name = "EMAIL_OF_REALSTATE";
            // 
            // NO_OF_EMPLOYEE
            // 
            NO_OF_EMPLOYEE.DataPropertyName = "DEPARTMENT_ID";
            NO_OF_EMPLOYEE.HeaderText = "DEPARTMENT ID";
            NO_OF_EMPLOYEE.Name = "NO_OF_EMPLOYEE";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "SALARY";
            Column8.HeaderText = "SALARY";
            Column8.Name = "Column8";
            // 
            // SALARY
            // 
            SALARY.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SALARY.Location = new Point(325, 311);
            SALARY.Name = "SALARY";
            SALARY.Size = new Size(100, 24);
            SALARY.TabIndex = 44;
            // 
            // NFE
            // 
            NFE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NFE.Location = new Point(325, 77);
            NFE.Name = "NFE";
            NFE.Size = new Size(100, 24);
            NFE.TabIndex = 43;
            // 
            // PNOFE
            // 
            PNOFE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNOFE.Location = new Point(325, 117);
            PNOFE.Name = "PNOFE";
            PNOFE.Size = new Size(100, 24);
            PNOFE.TabIndex = 42;
            // 
            // EOFE
            // 
            EOFE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EOFE.Location = new Point(325, 156);
            EOFE.Name = "EOFE";
            EOFE.Size = new Size(100, 24);
            EOFE.TabIndex = 41;
            // 
            // AOFE
            // 
            AOFE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AOFE.Location = new Point(325, 192);
            AOFE.Name = "AOFE";
            AOFE.Size = new Size(100, 24);
            AOFE.TabIndex = 40;
            // 
            // DID
            // 
            DID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DID.Location = new Point(325, 272);
            DID.Name = "DID";
            DID.Size = new Size(100, 24);
            DID.TabIndex = 38;
            // 
            // EID
            // 
            EID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EID.Location = new Point(325, 36);
            EID.Name = "EID";
            EID.Size = new Size(100, 24);
            EID.TabIndex = 37;
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exitbtn.Location = new Point(1384, 399);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 31);
            exitbtn.TabIndex = 36;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitBtn_Click;
            // 
            // WONPID
            // 
            WONPID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            WONPID.Location = new Point(325, 234);
            WONPID.Name = "WONPID";
            WONPID.Size = new Size(100, 24);
            WONPID.TabIndex = 39;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextbtn.Location = new Point(1180, 399);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 31);
            nextbtn.TabIndex = 35;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // viewbtn
            // 
            viewbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            viewbtn.Location = new Point(1075, 399);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 31);
            viewbtn.TabIndex = 34;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.Location = new Point(845, 399);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 31);
            Deletebtn.TabIndex = 33;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            editbtn.Location = new Point(734, 399);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 31);
            editbtn.TabIndex = 32;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.Location = new Point(606, 399);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 31);
            savebtn.TabIndex = 31;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // LABEL8
            // 
            LABEL8.AutoSize = true;
            LABEL8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL8.Location = new Point(30, 311);
            LABEL8.Name = "LABEL8";
            LABEL8.Size = new Size(64, 18);
            LABEL8.TabIndex = 30;
            LABEL8.Text = "SALARY";
            // 
            // LABEL7
            // 
            LABEL7.AutoSize = true;
            LABEL7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL7.Location = new Point(30, 275);
            LABEL7.Name = "LABEL7";
            LABEL7.Size = new Size(129, 18);
            LABEL7.TabIndex = 29;
            LABEL7.Text = "DEPARTMENT ID";
            // 
            // LABEL6
            // 
            LABEL6.AutoSize = true;
            LABEL6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL6.Location = new Point(30, 237);
            LABEL6.Name = "LABEL6";
            LABEL6.Size = new Size(202, 18);
            LABEL6.TabIndex = 28;
            LABEL6.Text = "WORKING ON PROJECT ID";
            // 
            // LABEL5
            // 
            LABEL5.AutoSize = true;
            LABEL5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL5.Location = new Point(30, 192);
            LABEL5.Name = "LABEL5";
            LABEL5.Size = new Size(195, 18);
            LABEL5.TabIndex = 27;
            LABEL5.Text = "ADDRESS OF EMPLOYEE ";
            // 
            // LABEL4
            // 
            LABEL4.AutoSize = true;
            LABEL4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL4.Location = new Point(30, 156);
            LABEL4.Name = "LABEL4";
            LABEL4.Size = new Size(162, 18);
            LABEL4.TabIndex = 26;
            LABEL4.Text = "EMAIL OF EMPLOYEE";
            // 
            // LABEL3
            // 
            LABEL3.AutoSize = true;
            LABEL3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL3.Location = new Point(30, 117);
            LABEL3.Name = "LABEL3";
            LABEL3.Size = new Size(243, 18);
            LABEL3.TabIndex = 25;
            LABEL3.Text = "PHONE NUMBER OF EMPLOYEE";
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(30, 77);
            C.Name = "C";
            C.Size = new Size(162, 18);
            C.TabIndex = 24;
            C.Text = "NAME OF EMPLOYEE";
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL1.Location = new Point(30, 36);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(108, 18);
            LABEL1.TabIndex = 23;
            LABEL1.Text = "EMPLOYEE ID";
            // 
            // BACKBTN
            // 
            BACKBTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BACKBTN.Location = new Point(1277, 399);
            BACKBTN.Name = "BACKBTN";
            BACKBTN.Size = new Size(76, 31);
            BACKBTN.TabIndex = 46;
            BACKBTN.Text = "Back";
            BACKBTN.UseVisualStyleBackColor = true;
            BACKBTN.Click += BACKBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(859, 21);
            label2.Name = "label2";
            label2.Size = new Size(373, 39);
            label2.TabIndex = 49;
            label2.Text = "EMPLOYEE DETAILS";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(965, 398);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 32);
            Searchbtn.TabIndex = 76;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 450);
            Controls.Add(Searchbtn);
            Controls.Add(label2);
            Controls.Add(BACKBTN);
            Controls.Add(xGrid);
            Controls.Add(SALARY);
            Controls.Add(NFE);
            Controls.Add(PNOFE);
            Controls.Add(EOFE);
            Controls.Add(AOFE);
            Controls.Add(DID);
            Controls.Add(EID);
            Controls.Add(exitbtn);
            Controls.Add(WONPID);
            Controls.Add(nextbtn);
            Controls.Add(viewbtn);
            Controls.Add(Deletebtn);
            Controls.Add(editbtn);
            Controls.Add(savebtn);
            Controls.Add(LABEL8);
            Controls.Add(LABEL7);
            Controls.Add(LABEL6);
            Controls.Add(LABEL5);
            Controls.Add(LABEL4);
            Controls.Add(LABEL3);
            Controls.Add(C);
            Controls.Add(LABEL1);
            Name = "Employee";
            Text = "EMPLOYEE DETAILS";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)xGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView xGrid;
        private TextBox SALARY;
        private TextBox NFE;
        private TextBox PNOFE;
        private TextBox EOFE;
        private TextBox AOFE;
        private TextBox DID;
        private TextBox EID;
        private Button exitbtn;
        private TextBox WONPID;
        private Button nextbtn;
        private Button viewbtn;
        private Button Deletebtn;
        private Button editbtn;
        private Button savebtn;
        private Label LABEL8;
        private Label LABEL7;
        private Label LABEL6;
        private Label LABEL5;
        private Label LABEL4;
        private Label LABEL3;
        private Label C;
        private Label LABEL1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn EMAIL_OF_REALSTATE;
        private DataGridViewTextBoxColumn NO_OF_EMPLOYEE;
        private DataGridViewTextBoxColumn Column8;
        private Button button1;
        private Button PREVIOUSBTN;
        private Button BACKBTN;
        private Label label2;
        private Button Searchbtn;
    }

}