namespace RealState_Project
{
    partial class PropertyWhichAreAvailableForRent
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
            vbtn = new Button();
            zGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            extbtn = new Button();
            button2 = new Button();
            bckbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)zGrid).BeginInit();
            SuspendLayout();
            // 
            // vbtn
            // 
            vbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            vbtn.Location = new Point(452, 387);
            vbtn.Name = "vbtn";
            vbtn.Size = new Size(75, 35);
            vbtn.TabIndex = 19;
            vbtn.Text = "View";
            vbtn.UseVisualStyleBackColor = true;
            vbtn.Click += vbtn_Click;
            // 
            // zGrid
            // 
            zGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            zGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            zGrid.Location = new Point(141, 74);
            zGrid.Name = "zGrid";
            zGrid.RowTemplate.Height = 25;
            zGrid.Size = new Size(536, 277);
            zGrid.TabIndex = 16;
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
            Column3.DataPropertyName = "PROPERTY_RENT";
            Column3.HeaderText = "PROPERTY RENT";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TOTAL_NUMBER_OF_ROOMS";
            Column4.HeaderText = "TOTAL NUMBER OF ROOMS";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "LOCATION_OF_PROPERTY_FOR_RENT";
            Column5.HeaderText = "LOCATION OF PROPERTY FOR RENT";
            Column5.Name = "Column5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(154, 28);
            label1.Name = "label1";
            label1.Size = new Size(515, 31);
            label1.TabIndex = 21;
            label1.Text = "Property Which Are Available For Rent";
            // 
            // extbtn
            // 
            extbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            extbtn.Location = new Point(602, 387);
            extbtn.Name = "extbtn";
            extbtn.Size = new Size(75, 35);
            extbtn.TabIndex = 20;
            extbtn.Text = "Exit";
            extbtn.UseVisualStyleBackColor = true;
            extbtn.Click += extbtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(275, 387);
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
            bckbtn.Location = new Point(123, 387);
            bckbtn.Name = "bckbtn";
            bckbtn.Size = new Size(75, 35);
            bckbtn.TabIndex = 17;
            bckbtn.Text = "Back";
            bckbtn.UseVisualStyleBackColor = true;
            bckbtn.Click += bckbtn_Click;
            // 
            // PropertyWhichAreAvailableForRent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vbtn);
            Controls.Add(zGrid);
            Controls.Add(label1);
            Controls.Add(extbtn);
            Controls.Add(button2);
            Controls.Add(bckbtn);
            Name = "PropertyWhichAreAvailableForRent";
            Text = "PropertyWhichAreAvailableForRent";
            ((System.ComponentModel.ISupportInitialize)zGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button vbtn;
        private DataGridView zGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
        private Button extbtn;
        private Button button2;
        private Button bckbtn;
    }
}