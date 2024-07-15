namespace RealState_Project
{
    partial class PropertyWhichAreAvailableForSale
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
            jGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            bckbtn = new Button();
            button2 = new Button();
            vbtn = new Button();
            extbtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)jGrid).BeginInit();
            SuspendLayout();
            // 
            // jGrid
            // 
            jGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            jGrid.Location = new Point(82, 66);
            jGrid.Name = "jGrid";
            jGrid.RowTemplate.Height = 25;
            jGrid.Size = new Size(536, 277);
            jGrid.TabIndex = 10;
            jGrid.CellContentClick += jGrid_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "PROPERTY_ID";
            Column1.HeaderText = "Property ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "PROPERTY_OWNER_NAME";
            Column2.HeaderText = "Property Owner Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PROPERTY_PRICE";
            Column3.HeaderText = "Property Price";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TOTAL_NUMBER_OF_ROOMS";
            Column4.HeaderText = "Total Number Of Rooms";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "LOCATION_OF_PROPERTY";
            Column5.HeaderText = "Location Of Property";
            Column5.Name = "Column5";
            // 
            // bckbtn
            // 
            bckbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            bckbtn.Location = new Point(64, 379);
            bckbtn.Name = "bckbtn";
            bckbtn.Size = new Size(75, 35);
            bckbtn.TabIndex = 11;
            bckbtn.Text = "Back";
            bckbtn.UseVisualStyleBackColor = true;
            bckbtn.Click += bckBtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(216, 379);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 12;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // vbtn
            // 
            vbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            vbtn.Location = new Point(393, 379);
            vbtn.Name = "vbtn";
            vbtn.Size = new Size(75, 35);
            vbtn.TabIndex = 13;
            vbtn.Text = "View";
            vbtn.UseVisualStyleBackColor = true;
            vbtn.Click += vbtn_Click;
            // 
            // extbtn
            // 
            extbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            extbtn.Location = new Point(543, 379);
            extbtn.Name = "extbtn";
            extbtn.Size = new Size(75, 35);
            extbtn.TabIndex = 14;
            extbtn.Text = "Exit";
            extbtn.UseVisualStyleBackColor = true;
            extbtn.Click += extbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 20);
            label1.Name = "label1";
            label1.Size = new Size(511, 31);
            label1.TabIndex = 15;
            label1.Text = "Property Which Are Available For Sale";
            label1.Click += label1_Click_1;
            // 
            // PropertyWhichAreAvailableForSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 450);
            Controls.Add(label1);
            Controls.Add(extbtn);
            Controls.Add(vbtn);
            Controls.Add(button2);
            Controls.Add(bckbtn);
            Controls.Add(jGrid);
            Name = "PropertyWhichAreAvailableForSale";
            Text = "PropertyWhichAreAvailableForSale";
            ((System.ComponentModel.ISupportInitialize)jGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView jGrid;
        private Button bckbtn;
        private Button button2;
        private Button vbtn;
        private Button extbtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
    }
}