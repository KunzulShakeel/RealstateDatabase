namespace RealState_Project
{
    partial class Manager
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
            aGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            EMAIL_OF_REALSTATE = new DataGridViewTextBoxColumn();
            HANDLING_ID_OF_DEPARTMEN = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            exitbtn = new Button();
            SALARY = new TextBox();
            NOFM = new TextBox();
            PNOFM = new TextBox();
            EOFM = new TextBox();
            AOFM = new TextBox();
            HIDOFD = new TextBox();
            MID = new TextBox();
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
            Searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)aGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(858, 21);
            label2.Name = "label2";
            label2.Size = new Size(358, 39);
            label2.TabIndex = 74;
            label2.Text = "MANAGER DETAILS";
            label2.Click += label2_Click;
            // 
            // BACKBTN
            // 
            BACKBTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BACKBTN.Location = new Point(1286, 399);
            BACKBTN.Name = "BACKBTN";
            BACKBTN.Size = new Size(76, 31);
            BACKBTN.TabIndex = 73;
            BACKBTN.Text = "Back";
            BACKBTN.UseVisualStyleBackColor = true;
            BACKBTN.Click += BACKBTN_Click;
            // 
            // aGrid
            // 
            aGrid.AccessibleName = "";
            aGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            aGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, EMAIL_OF_REALSTATE, HANDLING_ID_OF_DEPARTMEN, Column8 });
            aGrid.Location = new Point(605, 89);
            aGrid.Name = "aGrid";
            aGrid.Size = new Size(840, 257);
            aGrid.TabIndex = 72;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "MANAGER_ID";
            Column1.HeaderText = "MANAGER ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "NAME_OF_MANAGER";
            Column2.HeaderText = "NAME OF MANAGER";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PHONE_NUMBER_OF_MANAGER";
            Column3.HeaderText = "PHONE NUMBER OF MANAGER";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "EMAIL_OF_MANAGER";
            Column4.HeaderText = "EMAIL OF MANAGER";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ADDRESS_OF_MANAGER";
            Column5.HeaderText = "ADDRESS OF MANAGER";
            Column5.Name = "Column5";
            // 
            // EMAIL_OF_REALSTATE
            // 
            EMAIL_OF_REALSTATE.DataPropertyName = "WORKING_ON_PROJECT_ID";
            EMAIL_OF_REALSTATE.HeaderText = "WORKING ON PROJECT ID";
            EMAIL_OF_REALSTATE.Name = "EMAIL_OF_REALSTATE";
            // 
            // HANDLING_ID_OF_DEPARTMEN
            // 
            HANDLING_ID_OF_DEPARTMEN.DataPropertyName = "HANDLING_ID_OF_DEPARTMENT";
            HANDLING_ID_OF_DEPARTMEN.HeaderText = "HANDLING ID OF DEPARTMENT";
            HANDLING_ID_OF_DEPARTMEN.Name = "HANDLING_ID_OF_DEPARTMEN";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "SALARY";
            Column8.HeaderText = "SALARY";
            Column8.Name = "Column8";
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exitbtn.Location = new Point(1383, 399);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 31);
            exitbtn.TabIndex = 63;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // SALARY
            // 
            SALARY.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SALARY.Location = new Point(324, 311);
            SALARY.Name = "SALARY";
            SALARY.Size = new Size(100, 24);
            SALARY.TabIndex = 71;
            // 
            // NOFM
            // 
            NOFM.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            NOFM.Location = new Point(324, 77);
            NOFM.Name = "NOFM";
            NOFM.Size = new Size(100, 24);
            NOFM.TabIndex = 70;
            // 
            // PNOFM
            // 
            PNOFM.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNOFM.Location = new Point(324, 117);
            PNOFM.Name = "PNOFM";
            PNOFM.Size = new Size(100, 24);
            PNOFM.TabIndex = 69;
            // 
            // EOFM
            // 
            EOFM.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EOFM.Location = new Point(324, 156);
            EOFM.Name = "EOFM";
            EOFM.Size = new Size(100, 24);
            EOFM.TabIndex = 68;
            // 
            // AOFM
            // 
            AOFM.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AOFM.Location = new Point(324, 192);
            AOFM.Name = "AOFM";
            AOFM.Size = new Size(100, 24);
            AOFM.TabIndex = 67;
            // 
            // HIDOFD
            // 
            HIDOFD.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            HIDOFD.Location = new Point(324, 272);
            HIDOFD.Name = "HIDOFD";
            HIDOFD.Size = new Size(100, 24);
            HIDOFD.TabIndex = 65;
            // 
            // MID
            // 
            MID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MID.Location = new Point(324, 36);
            MID.Name = "MID";
            MID.Size = new Size(100, 24);
            MID.TabIndex = 64;
            // 
            // WONPID
            // 
            WONPID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            WONPID.Location = new Point(324, 234);
            WONPID.Name = "WONPID";
            WONPID.Size = new Size(100, 24);
            WONPID.TabIndex = 66;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextbtn.Location = new Point(1164, 399);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 31);
            nextbtn.TabIndex = 62;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // viewbtn
            // 
            viewbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            viewbtn.Location = new Point(1063, 399);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 31);
            viewbtn.TabIndex = 61;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.Location = new Point(858, 399);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 31);
            Deletebtn.TabIndex = 60;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            editbtn.Location = new Point(733, 399);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 31);
            editbtn.TabIndex = 59;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.Location = new Point(605, 399);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 31);
            savebtn.TabIndex = 58;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // LABEL8
            // 
            LABEL8.AutoSize = true;
            LABEL8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL8.Location = new Point(29, 311);
            LABEL8.Name = "LABEL8";
            LABEL8.Size = new Size(64, 18);
            LABEL8.TabIndex = 57;
            LABEL8.Text = "SALARY";
            // 
            // LABEL7
            // 
            LABEL7.AutoSize = true;
            LABEL7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL7.Location = new Point(29, 272);
            LABEL7.Name = "LABEL7";
            LABEL7.Size = new Size(234, 18);
            LABEL7.TabIndex = 56;
            LABEL7.Text = "HANDLING ID OF DEPARTMENT";
            // 
            // LABEL6
            // 
            LABEL6.AutoSize = true;
            LABEL6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL6.Location = new Point(29, 234);
            LABEL6.Name = "LABEL6";
            LABEL6.Size = new Size(202, 18);
            LABEL6.TabIndex = 55;
            LABEL6.Text = "WORKING ON PROJECT ID";
            // 
            // LABEL5
            // 
            LABEL5.AutoSize = true;
            LABEL5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL5.Location = new Point(29, 192);
            LABEL5.Name = "LABEL5";
            LABEL5.Size = new Size(184, 18);
            LABEL5.TabIndex = 54;
            LABEL5.Text = "ADDRESS OF MANAGER";
            // 
            // LABEL4
            // 
            LABEL4.AutoSize = true;
            LABEL4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL4.Location = new Point(29, 156);
            LABEL4.Name = "LABEL4";
            LABEL4.Size = new Size(155, 18);
            LABEL4.TabIndex = 53;
            LABEL4.Text = "EMAIL OF MANAGER";
            // 
            // LABEL3
            // 
            LABEL3.AutoSize = true;
            LABEL3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL3.Location = new Point(29, 117);
            LABEL3.Name = "LABEL3";
            LABEL3.Size = new Size(236, 18);
            LABEL3.TabIndex = 52;
            LABEL3.Text = "PHONE NUMBER OF MANAGER";
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(29, 77);
            C.Name = "C";
            C.Size = new Size(155, 18);
            C.TabIndex = 51;
            C.Text = "NAME OF MANAGER";
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL1.Location = new Point(29, 36);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(101, 18);
            LABEL1.TabIndex = 50;
            LABEL1.Text = "MANAGER ID";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(958, 399);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 32);
            Searchbtn.TabIndex = 75;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1487, 450);
            Controls.Add(Searchbtn);
            Controls.Add(label2);
            Controls.Add(BACKBTN);
            Controls.Add(aGrid);
            Controls.Add(exitbtn);
            Controls.Add(SALARY);
            Controls.Add(NOFM);
            Controls.Add(PNOFM);
            Controls.Add(EOFM);
            Controls.Add(AOFM);
            Controls.Add(HIDOFD);
            Controls.Add(MID);
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
            Name = "Manager";
            Text = "MANAGER DETAILS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)aGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BACKBTN;
        private DataGridView aGrid;
        private Button exitbtn;
        private TextBox SALARY;
        private TextBox NOFM;
        private TextBox PNOFM;
        private TextBox EOFM;
        private TextBox AOFM;
        private TextBox HIDOFD;
        private TextBox MID;
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
        private DataGridViewTextBoxColumn HANDLING_ID_OF_DEPARTMEN;
        private DataGridViewTextBoxColumn Column8;
        private Button Searchbtn;
    }
}
