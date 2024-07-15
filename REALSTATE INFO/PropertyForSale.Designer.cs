namespace RealState_Project
{
    partial class PropertyForSale
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
            eGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            LOCATION_OF_PROPERTY = new DataGridViewTextBoxColumn();
            exitbtn = new Button();
            POWN = new TextBox();
            AIDWONP = new TextBox();
            PP = new TextBox();
            TNOFR = new TextBox();
            PID = new TextBox();
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
            label6 = new Label();
            LOFP = new TextBox();
            Searchbtn = new Button();
            btn_cheap = new Button();
            ((System.ComponentModel.ISupportInitialize)eGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(619, 15);
            label2.Name = "label2";
            label2.Size = new Size(400, 39);
            label2.TabIndex = 143;
            label2.Text = "PROPERTY FOR SALE";
            // 
            // BACKBTN
            // 
            BACKBTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BACKBTN.Location = new Point(1250, 405);
            BACKBTN.Name = "BACKBTN";
            BACKBTN.Size = new Size(76, 31);
            BACKBTN.TabIndex = 142;
            BACKBTN.Text = "Back";
            BACKBTN.UseVisualStyleBackColor = true;
            BACKBTN.Click += BACKBTN_Click;
            // 
            // eGrid
            // 
            eGrid.AccessibleName = "";
            eGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column5, LOCATION_OF_PROPERTY });
            eGrid.Location = new Point(543, 80);
            eGrid.Name = "eGrid";
            eGrid.Size = new Size(547, 257);
            eGrid.TabIndex = 141;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "PROPERTY_ID";
            Column1.HeaderText = "PROPERTY ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "PROPERTY_OWNER_NAME";
            Column2.HeaderText = "PROPERTY OWNER NAME";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PROPERTY_PRICE";
            Column4.HeaderText = "PROPERTY PRICE";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TOTAL_NUMBER_OF_ROOMS";
            Column5.HeaderText = "TOTAL NUMBER OF ROOMS";
            Column5.Name = "Column5";
            // 
            // LOCATION_OF_PROPERTY
            // 
            LOCATION_OF_PROPERTY.DataPropertyName = "LOCATION_OF_PROPERTY";
            LOCATION_OF_PROPERTY.HeaderText = "LOCATION OF PROPERTY";
            LOCATION_OF_PROPERTY.Name = "LOCATION_OF_PROPERTY";
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exitbtn.Location = new Point(1369, 405);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 31);
            exitbtn.TabIndex = 135;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // POWN
            // 
            POWN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            POWN.Location = new Point(310, 103);
            POWN.Name = "POWN";
            POWN.Size = new Size(100, 24);
            POWN.TabIndex = 140;
            // 
            // AIDWONP
            // 
            AIDWONP.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AIDWONP.Location = new Point(310, 147);
            AIDWONP.Name = "AIDWONP";
            AIDWONP.Size = new Size(100, 24);
            AIDWONP.TabIndex = 139;
            // 
            // PP
            // 
            PP.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PP.Location = new Point(310, 189);
            PP.Name = "PP";
            PP.Size = new Size(100, 24);
            PP.TabIndex = 138;
            // 
            // TNOFR
            // 
            TNOFR.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TNOFR.Location = new Point(310, 229);
            TNOFR.Name = "TNOFR";
            TNOFR.Size = new Size(100, 24);
            TNOFR.TabIndex = 137;
            // 
            // PID
            // 
            PID.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PID.Location = new Point(310, 56);
            PID.Name = "PID";
            PID.Size = new Size(100, 24);
            PID.TabIndex = 136;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextbtn.Location = new Point(1130, 405);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 31);
            nextbtn.TabIndex = 134;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // viewbtn
            // 
            viewbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            viewbtn.Location = new Point(1029, 404);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 31);
            viewbtn.TabIndex = 133;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.Location = new Point(823, 405);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 31);
            Deletebtn.TabIndex = 132;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            editbtn.Location = new Point(701, 405);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 31);
            editbtn.TabIndex = 131;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.Location = new Point(582, 407);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(74, 31);
            savebtn.TabIndex = 130;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // LABEL5
            // 
            LABEL5.AutoSize = true;
            LABEL5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL5.Location = new Point(15, 232);
            LABEL5.Name = "LABEL5";
            LABEL5.Size = new Size(212, 18);
            LABEL5.TabIndex = 129;
            LABEL5.Text = "TOTAL NUMBER OF ROOMS";
            // 
            // LABEL4
            // 
            LABEL4.AutoSize = true;
            LABEL4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL4.Location = new Point(15, 189);
            LABEL4.Name = "LABEL4";
            LABEL4.Size = new Size(139, 18);
            LABEL4.TabIndex = 128;
            LABEL4.Text = "PROPERTY PRICE";
            // 
            // LABEL3
            // 
            LABEL3.AutoSize = true;
            LABEL3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL3.Location = new Point(15, 150);
            LABEL3.Name = "LABEL3";
            LABEL3.Size = new Size(155, 18);
            LABEL3.TabIndex = 127;
            LABEL3.Text = "AGENT ID WORKING";
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(15, 103);
            C.Name = "C";
            C.Size = new Size(200, 18);
            C.TabIndex = 126;
            C.Text = "PROPERTY OWNER NAME";
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL1.Location = new Point(15, 59);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(108, 18);
            LABEL1.TabIndex = 125;
            LABEL1.Text = "PROPERTY ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 280);
            label6.Name = "label6";
            label6.Size = new Size(194, 18);
            label6.TabIndex = 144;
            label6.Text = "LOCATION OF PROPERTY";
            // 
            // LOFP
            // 
            LOFP.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LOFP.Location = new Point(310, 277);
            LOFP.Name = "LOFP";
            LOFP.Size = new Size(100, 24);
            LOFP.TabIndex = 145;
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(922, 404);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 32);
            Searchbtn.TabIndex = 146;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // btn_cheap
            // 
            btn_cheap.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cheap.Location = new Point(390, 407);
            btn_cheap.Name = "btn_cheap";
            btn_cheap.Size = new Size(166, 31);
            btn_cheap.TabIndex = 169;
            btn_cheap.Text = "Cheap Properties";
            btn_cheap.UseVisualStyleBackColor = true;
            btn_cheap.Click += btn_cheap_Click;
            // 
            // PropertyForSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 450);
            Controls.Add(btn_cheap);
            Controls.Add(Searchbtn);
            Controls.Add(LOFP);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(BACKBTN);
            Controls.Add(eGrid);
            Controls.Add(exitbtn);
            Controls.Add(POWN);
            Controls.Add(AIDWONP);
            Controls.Add(PP);
            Controls.Add(TNOFR);
            Controls.Add(PID);
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
            Name = "PropertyForSale";
            Text = "PROPERTY FOR SALE";
            ((System.ComponentModel.ISupportInitialize)eGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BACKBTN;
        private DataGridView eGrid;
        private Button exitbtn;
        private TextBox POWN;
        private TextBox AIDWONP;
        private TextBox PP;
        private TextBox TNOFR;
        private TextBox PID;
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
        private Label label6;
        private TextBox LOFP;
        private Button Searchbtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn LOCATION_OF_PROPERTY;
        private Button btn_cheap;
    }
}
