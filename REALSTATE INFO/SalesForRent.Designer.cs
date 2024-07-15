namespace RealState_Project
{
    partial class SalesForRent
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
            PITXRENOT = new TextBox();
            label6 = new Label();
            label2 = new Label();
            PPRCE = new TextBox();
            BACKBTN = new Button();
            iGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            LOCATION_OF_PROPERTY_FOR_RENT = new DataGridViewTextBoxColumn();
            exitbtn = new Button();
            PAONRE = new TextBox();
            PNAONRE = new TextBox();
            PRBANE = new TextBox();
            SRIDE = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)iGrid).BeginInit();
            SuspendLayout();
            // 
            // PITXRENOT
            // 
            PITXRENOT.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PITXRENOT.Location = new Point(331, 272);
            PITXRENOT.Name = "PITXRENOT";
            PITXRENOT.Size = new Size(100, 24);
            PITXRENOT.TabIndex = 229;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 278);
            label6.Name = "label6";
            label6.Size = new Size(239, 18);
            label6.TabIndex = 228;
            label6.Text = "PROPERTY IS TAX PAID OR NOT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(665, 21);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(487, 39);
            label2.TabIndex = 227;
            label2.Text = "SALES FOR RENT DETAILS";
            // 
            // PPRCE
            // 
            PPRCE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PPRCE.Location = new Point(331, 230);
            PPRCE.Name = "PPRCE";
            PPRCE.Size = new Size(100, 24);
            PPRCE.TabIndex = 221;
            // 
            // BACKBTN
            // 
            BACKBTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BACKBTN.Location = new Point(1272, 409);
            BACKBTN.Name = "BACKBTN";
            BACKBTN.Size = new Size(76, 31);
            BACKBTN.TabIndex = 226;
            BACKBTN.Text = "Back";
            BACKBTN.UseVisualStyleBackColor = true;
            BACKBTN.Click += BACKBTN_Click;
            // 
            // iGrid
            // 
            iGrid.AccessibleName = "";
            iGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            iGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, LOCATION_OF_PROPERTY_FOR_RENT });
            iGrid.Location = new Point(591, 90);
            iGrid.Name = "iGrid";
            iGrid.Size = new Size(642, 247);
            iGrid.TabIndex = 225;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "SALES_FOR_RENT_ID";
            Column1.HeaderText = "SALES FOR RENT ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "PROPERTY_AVAILABLE_ON_RENT";
            Column2.HeaderText = "PROPERTY AVAILABLE ON RENT";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PROPERTY_NOT_AVAILABLE_ON_RENT";
            Column3.HeaderText = "PROPERTY NOT AVAILABLE ON RENT";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PROPERTY_RENTED_BY_AGENT_NAME";
            Column4.HeaderText = "PROPERTY RENTED BY AGENT NAME";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "PER_PROPERTY_RENTED_COMMISSION";
            Column5.HeaderText = "PER PROPERTY RENTED COMMISSION";
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
            exitbtn.Location = new Point(1390, 409);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 31);
            exitbtn.TabIndex = 219;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // PAONRE
            // 
            PAONRE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PAONRE.Location = new Point(331, 107);
            PAONRE.Name = "PAONRE";
            PAONRE.Size = new Size(100, 24);
            PAONRE.TabIndex = 224;
            // 
            // PNAONRE
            // 
            PNAONRE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNAONRE.Location = new Point(331, 148);
            PNAONRE.Name = "PNAONRE";
            PNAONRE.Size = new Size(100, 24);
            PNAONRE.TabIndex = 223;
            // 
            // PRBANE
            // 
            PRBANE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PRBANE.Location = new Point(331, 190);
            PRBANE.Name = "PRBANE";
            PRBANE.Size = new Size(100, 24);
            PRBANE.TabIndex = 222;
            // 
            // SRIDE
            // 
            SRIDE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SRIDE.Location = new Point(331, 63);
            SRIDE.Name = "SRIDE";
            SRIDE.Size = new Size(100, 24);
            SRIDE.TabIndex = 220;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextbtn.Location = new Point(1170, 409);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(75, 31);
            nextbtn.TabIndex = 218;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // viewbtn
            // 
            viewbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            viewbtn.Location = new Point(1061, 409);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 31);
            viewbtn.TabIndex = 217;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.Location = new Point(848, 410);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 31);
            Deletebtn.TabIndex = 216;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            editbtn.Location = new Point(728, 409);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 31);
            editbtn.TabIndex = 215;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.Location = new Point(591, 409);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(74, 31);
            savebtn.TabIndex = 214;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // LABEL5
            // 
            LABEL5.AutoSize = true;
            LABEL5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL5.Location = new Point(24, 236);
            LABEL5.Name = "LABEL5";
            LABEL5.Size = new Size(293, 18);
            LABEL5.TabIndex = 213;
            LABEL5.Text = "PER PROPERTY RENTED COMMISSION";
            // 
            // LABEL4
            // 
            LABEL4.AutoSize = true;
            LABEL4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL4.Location = new Point(24, 193);
            LABEL4.Name = "LABEL4";
            LABEL4.Size = new Size(281, 18);
            LABEL4.TabIndex = 212;
            LABEL4.Text = "PROPERTY RENTED BY AGENT NAME";
            // 
            // LABEL3
            // 
            LABEL3.AutoSize = true;
            LABEL3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL3.Location = new Point(24, 154);
            LABEL3.Name = "LABEL3";
            LABEL3.Size = new Size(277, 18);
            LABEL3.TabIndex = 211;
            LABEL3.Text = "PROPERTY NOT AVAILABLE ON RENT";
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(24, 107);
            C.Name = "C";
            C.Size = new Size(241, 18);
            C.TabIndex = 210;
            C.Text = "PROPERTY AVAILABLE ON RENT";
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL1.Location = new Point(24, 63);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(154, 18);
            LABEL1.TabIndex = 209;
            LABEL1.Text = "SALES FOR RENT ID";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(958, 409);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(81, 32);
            Searchbtn.TabIndex = 230;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // SalesForRent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 450);
            Controls.Add(Searchbtn);
            Controls.Add(PITXRENOT);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(PPRCE);
            Controls.Add(BACKBTN);
            Controls.Add(iGrid);
            Controls.Add(exitbtn);
            Controls.Add(PAONRE);
            Controls.Add(PNAONRE);
            Controls.Add(PRBANE);
            Controls.Add(SRIDE);
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
            Name = "SalesForRent";
            Text = "SALES FOR RENT DETAILS";
            ((System.ComponentModel.ISupportInitialize)iGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PITXRENOT;
        private Label label6;
        private Label label2;
        private TextBox PPRCE;
        private Button BACKBTN;
        private DataGridView iGrid;
        private Button exitbtn;
        private TextBox PAONRE;
        private TextBox PNAONRE;
        private TextBox PRBANE;
        private TextBox SRIDE;
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
