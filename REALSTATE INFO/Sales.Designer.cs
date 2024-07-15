namespace RealState_Project
{
    partial class Sales
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
            PITXRN = new TextBox();
            label6 = new Label();
            label2 = new Label();
            PPSC = new TextBox();
            BACKBTN = new Button();
            hGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            LOCATION_OF_PROPERTY_FOR_RENT = new DataGridViewTextBoxColumn();
            exitbtn = new Button();
            PWISS = new TextBox();
            PWAA = new TextBox();
            PSBYAN = new TextBox();
            SID = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)hGrid).BeginInit();
            SuspendLayout();
            // 
            // PITXRN
            // 
            PITXRN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PITXRN.Location = new Point(297, 270);
            PITXRN.Name = "PITXRN";
            PITXRN.Size = new Size(100, 24);
            PITXRN.TabIndex = 208;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 276);
            label6.Name = "label6";
            label6.Size = new Size(239, 18);
            label6.TabIndex = 207;
            label6.Text = "PROPERTY IS TAX PAID OR NOT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(737, 9);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(294, 39);
            label2.TabIndex = 206;
            label2.Text = "SALES DETAILS";
            // 
            // PPSC
            // 
            PPSC.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PPSC.Location = new Point(297, 228);
            PPSC.Name = "PPSC";
            PPSC.Size = new Size(100, 24);
            PPSC.TabIndex = 200;
            // 
            // BACKBTN
            // 
            BACKBTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BACKBTN.Location = new Point(1270, 408);
            BACKBTN.Name = "BACKBTN";
            BACKBTN.Size = new Size(76, 31);
            BACKBTN.TabIndex = 205;
            BACKBTN.Text = "Back";
            BACKBTN.UseVisualStyleBackColor = true;
            BACKBTN.Click += BACKBTN_Click;
            // 
            // hGrid
            // 
            hGrid.AccessibleName = "";
            hGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, LOCATION_OF_PROPERTY_FOR_RENT });
            hGrid.Location = new Point(585, 88);
            hGrid.Name = "hGrid";
            hGrid.Size = new Size(642, 247);
            hGrid.TabIndex = 204;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SALES_ID";
            Column1.HeaderText = "SALES ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "PROPERTY_WHICH_IS_SOLD";
            Column2.HeaderText = "PROPERTY WHICH IS SOLD";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PROPERTY_WHICH_ARE_AVAILABLE";
            Column3.HeaderText = "PROPERTY WHICH ARE AVAILABLE";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PROPERTY_SOLD_BY_AGENT_NAME";
            Column4.HeaderText = "PROPERTY SOLD BY AGENT NAME";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "PER_PROPERTY_SOLD_COMMISSION";
            Column5.HeaderText = "PER PROPERTY SOLD COMMISSION";
            Column5.Name = "Column5";
            // 
            // LOCATION_OF_PROPERTY_FOR_RENT
            // 
            LOCATION_OF_PROPERTY_FOR_RENT.DataPropertyName = "PROPERTY_IS_TAX_PAID_OR_NOT";
            LOCATION_OF_PROPERTY_FOR_RENT.HeaderText = "PROPERTY IS TAX PAID OR NOT";
            LOCATION_OF_PROPERTY_FOR_RENT.Name = "LOCATION_OF_PROPERTY_FOR_RENT";
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exitbtn.Location = new Point(1372, 407);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 31);
            exitbtn.TabIndex = 198;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // PWISS
            // 
            PWISS.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PWISS.Location = new Point(297, 105);
            PWISS.Name = "PWISS";
            PWISS.Size = new Size(100, 24);
            PWISS.TabIndex = 203;
            // 
            // PWAA
            // 
            PWAA.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PWAA.Location = new Point(297, 146);
            PWAA.Name = "PWAA";
            PWAA.Size = new Size(100, 24);
            PWAA.TabIndex = 202;
            // 
            // PSBYAN
            // 
            PSBYAN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PSBYAN.Location = new Point(297, 188);
            PSBYAN.Name = "PSBYAN";
            PSBYAN.Size = new Size(100, 24);
            PSBYAN.TabIndex = 201;
            // 
            // SID
            // 
            SID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SID.Location = new Point(297, 61);
            SID.Name = "SID";
            SID.Size = new Size(100, 24);
            SID.TabIndex = 199;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextbtn.Location = new Point(1152, 407);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 31);
            nextbtn.TabIndex = 197;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // viewbtn
            // 
            viewbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            viewbtn.Location = new Point(1034, 407);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 31);
            viewbtn.TabIndex = 196;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.Location = new Point(817, 407);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 31);
            Deletebtn.TabIndex = 195;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            editbtn.Location = new Point(709, 408);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 31);
            editbtn.TabIndex = 194;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.Location = new Point(585, 408);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(74, 31);
            savebtn.TabIndex = 193;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // LABEL5
            // 
            LABEL5.AutoSize = true;
            LABEL5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL5.Location = new Point(18, 234);
            LABEL5.Name = "LABEL5";
            LABEL5.Size = new Size(272, 18);
            LABEL5.TabIndex = 192;
            LABEL5.Text = "PER PROPERTY SOLD COMMISSION";
            // 
            // LABEL4
            // 
            LABEL4.AutoSize = true;
            LABEL4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL4.Location = new Point(18, 191);
            LABEL4.Name = "LABEL4";
            LABEL4.Size = new Size(260, 18);
            LABEL4.TabIndex = 191;
            LABEL4.Text = "PROPERTY SOLD BY AGENT NAME";
            // 
            // LABEL3
            // 
            LABEL3.AutoSize = true;
            LABEL3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL3.Location = new Point(18, 152);
            LABEL3.Name = "LABEL3";
            LABEL3.Size = new Size(258, 18);
            LABEL3.TabIndex = 190;
            LABEL3.Text = "PROPERTY WHICH ARE AVAILABLE";
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(18, 105);
            C.Name = "C";
            C.Size = new Size(207, 18);
            C.TabIndex = 189;
            C.Text = "PROPERTY WHICH IS SOLD";
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL1.Location = new Point(18, 61);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(73, 18);
            LABEL1.TabIndex = 188;
            LABEL1.Text = "SALES ID";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(926, 407);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 32);
            Searchbtn.TabIndex = 209;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 450);
            Controls.Add(Searchbtn);
            Controls.Add(PITXRN);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(PPSC);
            Controls.Add(BACKBTN);
            Controls.Add(hGrid);
            Controls.Add(exitbtn);
            Controls.Add(PWISS);
            Controls.Add(PWAA);
            Controls.Add(PSBYAN);
            Controls.Add(SID);
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
            Name = "Sales";
            Text = "SALES DETAILS";
            ((System.ComponentModel.ISupportInitialize)hGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PITXRN;
        private Label label6;
        private Label label2;
        private TextBox PPSC;
        private Button BACKBTN;
        private DataGridView hGrid;
        private Button exitbtn;
        private TextBox PWISS;
        private TextBox PWAA;
        private TextBox PSBYAN;
        private TextBox SID;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn LOCATION_OF_PROPERTY_FOR_RENT;
        private Button Searchbtn;
    }
}
