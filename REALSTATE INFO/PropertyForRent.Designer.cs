namespace RealState_Project
{
    partial class PropertyForRent
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
            LOFPFRENT = new TextBox();
            label6 = new Label();
            label2 = new Label();
            TNFROOMS = new TextBox();
            BACKBTN = new Button();
            fGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            LOCATION_OF_PROPERTY_FOR_RENT = new DataGridViewTextBoxColumn();
            exitbtn = new Button();
            PFROWNER = new TextBox();
            AIDWONPFORR = new TextBox();
            PRENT = new TextBox();
            PFRID = new TextBox();
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
            btn_cheap = new Button();
            ((System.ComponentModel.ISupportInitialize)fGrid).BeginInit();
            SuspendLayout();
            // 
            // LOFPFRENT
            // 
            LOFPFRENT.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LOFPFRENT.Location = new Point(375, 277);
            LOFPFRENT.Name = "LOFPFRENT";
            LOFPFRENT.Size = new Size(100, 24);
            LOFPFRENT.TabIndex = 166;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 280);
            label6.Name = "label6";
            label6.Size = new Size(275, 18);
            label6.TabIndex = 165;
            label6.Text = "LOCATION OF PROPERTY FOR RENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(693, 19);
            label2.Name = "label2";
            label2.Size = new Size(406, 39);
            label2.TabIndex = 164;
            label2.Text = "PROPERTY FOR RENT";
            // 
            // TNFROOMS
            // 
            TNFROOMS.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TNFROOMS.Location = new Point(375, 229);
            TNFROOMS.Name = "TNFROOMS";
            TNFROOMS.Size = new Size(100, 24);
            TNFROOMS.TabIndex = 158;
            // 
            // BACKBTN
            // 
            BACKBTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BACKBTN.Location = new Point(1276, 407);
            BACKBTN.Name = "BACKBTN";
            BACKBTN.Size = new Size(76, 31);
            BACKBTN.TabIndex = 163;
            BACKBTN.Text = "Back";
            BACKBTN.UseVisualStyleBackColor = true;
            BACKBTN.Click += BACKBTN_Click;
            // 
            // fGrid
            // 
            fGrid.AccessibleName = "";
            fGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, LOCATION_OF_PROPERTY_FOR_RENT });
            fGrid.Location = new Point(591, 76);
            fGrid.Name = "fGrid";
            fGrid.Size = new Size(642, 257);
            fGrid.TabIndex = 162;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "PROPERTY_FOR_RENT_ID";
            Column1.HeaderText = "PROPERTY FOR RENT ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "PROPERTY__FOR_RENT_OWNER_NAME";
            Column2.HeaderText = "PROPERTY FOR RENT OWNER NAME";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "AGENT_ID_WORKING_ON_PROPERTY_FOR_RENT";
            Column3.HeaderText = "AGENT ID WORKING ON PROPERTY FOR RENT";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PROPERTY_RENT";
            Column4.HeaderText = "PROPERTY RENT";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TOTAL_NUMBER_OF_ROOMS";
            Column5.HeaderText = "TOTAL NUMBER OF ROOMS";
            Column5.Name = "Column5";
            // 
            // LOCATION_OF_PROPERTY_FOR_RENT
            // 
            LOCATION_OF_PROPERTY_FOR_RENT.DataPropertyName = "LOCATION_OF_PROPERTY_FOR_RENT";
            LOCATION_OF_PROPERTY_FOR_RENT.HeaderText = "LOCATION OF PROPERTY FOR RENT";
            LOCATION_OF_PROPERTY_FOR_RENT.Name = "LOCATION_OF_PROPERTY_FOR_RENT";
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exitbtn.Location = new Point(1387, 405);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 31);
            exitbtn.TabIndex = 156;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // PFROWNER
            // 
            PFROWNER.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PFROWNER.Location = new Point(375, 103);
            PFROWNER.Name = "PFROWNER";
            PFROWNER.Size = new Size(100, 24);
            PFROWNER.TabIndex = 161;
            // 
            // AIDWONPFORR
            // 
            AIDWONPFORR.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AIDWONPFORR.Location = new Point(375, 147);
            AIDWONPFORR.Name = "AIDWONPFORR";
            AIDWONPFORR.Size = new Size(100, 24);
            AIDWONPFORR.TabIndex = 160;
            // 
            // PRENT
            // 
            PRENT.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PRENT.Location = new Point(375, 189);
            PRENT.Name = "PRENT";
            PRENT.Size = new Size(100, 24);
            PRENT.TabIndex = 159;
            // 
            // PFRID
            // 
            PFRID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PFRID.Location = new Point(375, 59);
            PFRID.Name = "PFRID";
            PFRID.Size = new Size(100, 24);
            PFRID.TabIndex = 157;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextbtn.Location = new Point(1158, 407);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 31);
            nextbtn.TabIndex = 155;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // viewbtn
            // 
            viewbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            viewbtn.Location = new Point(1040, 407);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 31);
            viewbtn.TabIndex = 154;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.Location = new Point(841, 404);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 31);
            Deletebtn.TabIndex = 153;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            editbtn.Location = new Point(728, 405);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 31);
            editbtn.TabIndex = 152;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.Location = new Point(628, 407);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(74, 31);
            savebtn.TabIndex = 151;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // LABEL5
            // 
            LABEL5.AutoSize = true;
            LABEL5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL5.Location = new Point(24, 232);
            LABEL5.Name = "LABEL5";
            LABEL5.Size = new Size(212, 18);
            LABEL5.TabIndex = 150;
            LABEL5.Text = "TOTAL NUMBER OF ROOMS";
            // 
            // LABEL4
            // 
            LABEL4.AutoSize = true;
            LABEL4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL4.Location = new Point(24, 189);
            LABEL4.Name = "LABEL4";
            LABEL4.Size = new Size(135, 18);
            LABEL4.TabIndex = 149;
            LABEL4.Text = "PROPERTY RENT";
            // 
            // LABEL3
            // 
            LABEL3.AutoSize = true;
            LABEL3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL3.Location = new Point(24, 150);
            LABEL3.Name = "LABEL3";
            LABEL3.Size = new Size(349, 18);
            LABEL3.TabIndex = 148;
            LABEL3.Text = "AGENT ID WORKING ON PROPERTY FOR RENT";
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(24, 103);
            C.Name = "C";
            C.Size = new Size(281, 18);
            C.TabIndex = 147;
            C.Text = "PROPERTY FOR RENT OWNER NAME";
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL1.Location = new Point(24, 59);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(189, 18);
            LABEL1.TabIndex = 146;
            LABEL1.Text = "PROPERTY FOR RENT ID";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(946, 404);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 32);
            Searchbtn.TabIndex = 167;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // btn_cheap
            // 
            btn_cheap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cheap.Location = new Point(445, 407);
            btn_cheap.Name = "btn_cheap";
            btn_cheap.Size = new Size(166, 31);
            btn_cheap.TabIndex = 168;
            btn_cheap.Text = "Cheap Properties";
            btn_cheap.UseVisualStyleBackColor = true;
            btn_cheap.Click += btnCheap_Click;
            // 
            // PropertyForRent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 450);
            Controls.Add(btn_cheap);
            Controls.Add(Searchbtn);
            Controls.Add(LOFPFRENT);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(TNFROOMS);
            Controls.Add(BACKBTN);
            Controls.Add(fGrid);
            Controls.Add(exitbtn);
            Controls.Add(PFROWNER);
            Controls.Add(AIDWONPFORR);
            Controls.Add(PRENT);
            Controls.Add(PFRID);
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
            Name = "PropertyForRent";
            Text = "PROPERTY FOR RENT";
            Load += PropertyForRent_Load;
            ((System.ComponentModel.ISupportInitialize)fGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LOFPFRENT;
        private Label label6;
        private Label label2;
        private TextBox TNFROOMS;
        private Button BACKBTN;
        private DataGridView fGrid;
        private Button exitbtn;
        private TextBox PFROWNER;
        private TextBox AIDWONPFORR;
        private TextBox PRENT;
        private TextBox PFRID;
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
        private Button btn_cheap;
    }
}
