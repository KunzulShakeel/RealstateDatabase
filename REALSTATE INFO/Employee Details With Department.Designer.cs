namespace RealState_Project
{
    partial class EmployeeDetailsWithDepartment
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
            label1 = new Label();
            extbtn = new Button();
            vbtn = new Button();
            button2 = new Button();
            bckbtn = new Button();
            kGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            DEPARTMENT_NAME = new DataGridViewTextBoxColumn();
            SALARY = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)kGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(259, 28);
            label1.Name = "label1";
            label1.Size = new Size(467, 31);
            label1.TabIndex = 21;
            label1.Text = "Employee Details With Department";
            // 
            // extbtn
            // 
            extbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            extbtn.Location = new Point(707, 387);
            extbtn.Name = "extbtn";
            extbtn.Size = new Size(75, 35);
            extbtn.TabIndex = 20;
            extbtn.Text = "Exit";
            extbtn.UseVisualStyleBackColor = true;
            extbtn.Click += extbtn_Click;
            // 
            // vbtn
            // 
            vbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            vbtn.Location = new Point(557, 387);
            vbtn.Name = "vbtn";
            vbtn.Size = new Size(75, 35);
            vbtn.TabIndex = 19;
            vbtn.Text = "View";
            vbtn.UseVisualStyleBackColor = true;
            vbtn.Click += vbtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(380, 387);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 18;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bckbtn
            // 
            bckbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bckbtn.Location = new Point(228, 387);
            bckbtn.Name = "bckbtn";
            bckbtn.Size = new Size(75, 35);
            bckbtn.TabIndex = 17;
            bckbtn.Text = "Back";
            bckbtn.UseVisualStyleBackColor = true;
            bckbtn.Click += bckbtn_Click;
            // 
            // kGrid
            // 
            kGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, DEPARTMENT_NAME, SALARY });
            kGrid.Location = new Point(246, 74);
            kGrid.Name = "kGrid";
            kGrid.RowTemplate.Height = 25;
            kGrid.Size = new Size(536, 277);
            kGrid.TabIndex = 16;
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
            // DEPARTMENT_NAME
            // 
            DEPARTMENT_NAME.DataPropertyName = "DEPARTMENT_NAME";
            DEPARTMENT_NAME.HeaderText = "DEPARTMENT NAME";
            DEPARTMENT_NAME.Name = "DEPARTMENT_NAME";
            // 
            // SALARY
            // 
            SALARY.DataPropertyName = "SALARY";
            SALARY.HeaderText = "SALARY";
            SALARY.Name = "SALARY";
            // 
            // EmployeeDetailsWithDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 450);
            Controls.Add(label1);
            Controls.Add(extbtn);
            Controls.Add(vbtn);
            Controls.Add(button2);
            Controls.Add(bckbtn);
            Controls.Add(kGrid);
            Name = "EmployeeDetailsWithDepartment";
            Text = "EmployeeDetailsWithDepartment";
            ((System.ComponentModel.ISupportInitialize)kGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button extbtn;
        private Button vbtn;
        private Button button2;
        private Button bckbtn;
        private DataGridView kGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn DEPARTMENT_NAME;
        private DataGridViewTextBoxColumn SALARY;
    }
}