namespace REALSTATE_INFO
{
    partial class Departments
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
            label2 = new Label();
            BACKBTN = new Button();
            dGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            exitbtn = new Button();
            DN = new TextBox();
            NOFEW = new TextBox();
            EOFD = new TextBox();
            PNOFD = new TextBox();
            DID = new TextBox();
            nextbtn = new Button();
            viewbtn = new Button();
            Deletebtn = new Button();
            editbtn = new Button();
            savebtn = new Button();
            LABEL5 = new Label();
            LABEL4 = new Label();
            LABEL3 = new Label();
            C = new Label();
            LABEL1 = new Label();
            Searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(631, 9);
            label2.Name = "label2";
            label2.Size = new Size(459, 39);
            label2.TabIndex = 124;
            label2.Text = "DEPARTMENTS  DETAILS";
            // 
            // BACKBTN
            // 
            BACKBTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BACKBTN.Location = new Point(1271, 399);
            BACKBTN.Name = "BACKBTN";
            BACKBTN.Size = new Size(76, 31);
            BACKBTN.TabIndex = 123;
            BACKBTN.Text = "Back";
            BACKBTN.UseVisualStyleBackColor = true;
            BACKBTN.Click += BACKBTN_Click;
            // 
            // dGrid
            // 
            dGrid.AccessibleName = "";
            dGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dGrid.Location = new Point(594, 70);
            dGrid.Name = "dGrid";
            dGrid.Size = new Size(542, 257);
            dGrid.TabIndex = 122;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "DEPARTMENT_ID";
            Column1.HeaderText = "DEPARTMENT ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "DEPARTMENT_NAME";
            Column2.HeaderText = "DEPARTMENT NAME";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "NO_OF_EMPLOYEE_WORKING";
            Column3.HeaderText = "NO OF EMPLOYEE WORKING";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "EMAIL_OF_DEPARTMENT";
            Column4.HeaderText = "EMAIL OF DEPARTMENT";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "PHONE_NUMBER_OF_DEPARTMENT";
            Column5.HeaderText = "PHONE NUMBER OF DEPARTMENT";
            Column5.Name = "Column5";
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exitbtn.Location = new Point(1388, 399);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 31);
            exitbtn.TabIndex = 113;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // DN
            // 
            DN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DN.Location = new Point(322, 97);
            DN.Name = "DN";
            DN.Size = new Size(100, 24);
            DN.TabIndex = 120;
            // 
            // NOFEW
            // 
            NOFEW.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NOFEW.Location = new Point(322, 141);
            NOFEW.Name = "NOFEW";
            NOFEW.Size = new Size(100, 24);
            NOFEW.TabIndex = 119;
            // 
            // EOFD
            // 
            EOFD.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EOFD.Location = new Point(322, 183);
            EOFD.Name = "EOFD";
            EOFD.Size = new Size(100, 24);
            EOFD.TabIndex = 118;
            // 
            // PNOFD
            // 
            PNOFD.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNOFD.Location = new Point(322, 223);
            PNOFD.Name = "PNOFD";
            PNOFD.Size = new Size(100, 24);
            PNOFD.TabIndex = 117;
            // 
            // DID
            // 
            DID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DID.Location = new Point(322, 50);
            DID.Name = "DID";
            DID.Size = new Size(100, 24);
            DID.TabIndex = 114;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextbtn.Location = new Point(1151, 399);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 31);
            nextbtn.TabIndex = 112;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // viewbtn
            // 
            viewbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            viewbtn.Location = new Point(1037, 399);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 31);
            viewbtn.TabIndex = 111;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.Location = new Point(834, 399);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 31);
            Deletebtn.TabIndex = 110;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            editbtn.Location = new Point(700, 399);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 31);
            editbtn.TabIndex = 109;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.Location = new Point(582, 399);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(74, 31);
            savebtn.TabIndex = 108;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // LABEL5
            // 
            LABEL5.AutoSize = true;
            LABEL5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL5.Location = new Point(27, 226);
            LABEL5.Name = "LABEL5";
            LABEL5.Size = new Size(264, 18);
            LABEL5.TabIndex = 104;
            LABEL5.Text = "PHONE NUMBER OF DEPARTMENT";
            // 
            // LABEL4
            // 
            LABEL4.AutoSize = true;
            LABEL4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL4.Location = new Point(27, 183);
            LABEL4.Name = "LABEL4";
            LABEL4.Size = new Size(183, 18);
            LABEL4.TabIndex = 103;
            LABEL4.Text = "EMAIL OF DEPARTMENT";
            // 
            // LABEL3
            // 
            LABEL3.AutoSize = true;
            LABEL3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL3.Location = new Point(27, 144);
            LABEL3.Name = "LABEL3";
            LABEL3.Size = new Size(142, 18);
            LABEL3.TabIndex = 102;
            LABEL3.Text = "NO OF EMPLOYEE";
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(27, 97);
            C.Name = "C";
            C.Size = new Size(158, 18);
            C.TabIndex = 101;
            C.Text = "DEPARTMENT NAME";
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL1.Location = new Point(27, 53);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(129, 18);
            LABEL1.TabIndex = 100;
            LABEL1.Text = "DEPARTMENT ID";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(939, 399);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 32);
            Searchbtn.TabIndex = 125;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 450);
            Controls.Add(Searchbtn);
            Controls.Add(label2);
            Controls.Add(BACKBTN);
            Controls.Add(dGrid);
            Controls.Add(exitbtn);
            Controls.Add(DN);
            Controls.Add(NOFEW);
            Controls.Add(EOFD);
            Controls.Add(PNOFD);
            Controls.Add(DID);
            Controls.Add(nextbtn);
            Controls.Add(viewbtn);
            Controls.Add(Deletebtn);
            Controls.Add(editbtn);
            Controls.Add(savebtn);
            Controls.Add(LABEL5);
            Controls.Add(LABEL4);
            Controls.Add(LABEL3);
            Controls.Add(C);
            Controls.Add(LABEL1);
            Name = "Departments";
            Text = "DEPARTMENTS DETAILS";
            ((System.ComponentModel.ISupportInitialize)dGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BACKBTN;
        private DataGridView dGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button exitbtn;
        private TextBox DN;
        private TextBox NOFEW;
        private TextBox EOFD;
        private TextBox PNOFD;
        private TextBox DID;
        private Button nextbtn;
        private Button viewbtn;
        private Button Deletebtn;
        private Button editbtn;
        private Button savebtn;
        private Label LABEL5;
        private Label LABEL4;
        private Label LABEL3;
        private Label C;
        private Label LABEL1;
        private Button Searchbtn;
    }
}
