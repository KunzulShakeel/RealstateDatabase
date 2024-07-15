namespace RealState_Project
{
    partial class AgentDetailsWithWorkingprocject
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
            LGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            DEPARTMENT_NAME = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(228, 26);
            label1.Name = "label1";
            label1.Size = new Size(370, 31);
            label1.TabIndex = 27;
            label1.Text = "Agent Details With Projects";
            // 
            // extbtn
            // 
            extbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            extbtn.Location = new Point(602, 387);
            extbtn.Name = "extbtn";
            extbtn.Size = new Size(75, 35);
            extbtn.TabIndex = 26;
            extbtn.Text = "Exit";
            extbtn.UseVisualStyleBackColor = true;
            extbtn.Click += extbtn_Click;
            // 
            // vbtn
            // 
            vbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            vbtn.Location = new Point(452, 387);
            vbtn.Name = "vbtn";
            vbtn.Size = new Size(75, 35);
            vbtn.TabIndex = 25;
            vbtn.Text = "View";
            vbtn.UseVisualStyleBackColor = true;
            vbtn.Click += vbtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(275, 387);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 24;
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
            bckbtn.TabIndex = 23;
            bckbtn.Text = "Back";
            bckbtn.UseVisualStyleBackColor = true;
            bckbtn.Click += bckbtn_Click;
            // 
            // LGrid
            // 
            LGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, DEPARTMENT_NAME });
            LGrid.Location = new Point(141, 74);
            LGrid.Name = "LGrid";
            LGrid.RowTemplate.Height = 25;
            LGrid.Size = new Size(536, 277);
            LGrid.TabIndex = 22;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "AGENT_ID";
            Column1.HeaderText = "AGENT ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "AGENT_NAME";
            Column2.HeaderText = "AGENT NAME";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PHONE_NUMBER_OF_AGENT";
            Column3.HeaderText = "PHONE NUMBER OF AGENT";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "EMAIL_OF_AGENT";
            Column4.HeaderText = "EMAIL OF AGENT";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ADDRESS_OF_AGENT";
            Column5.HeaderText = "ADDRESS OF AGENT";
            Column5.Name = "Column5";
            // 
            // DEPARTMENT_NAME
            // 
            DEPARTMENT_NAME.DataPropertyName = "PROJECT_NAME";
            DEPARTMENT_NAME.HeaderText = "PROJECT NAME";
            DEPARTMENT_NAME.Name = "DEPARTMENT_NAME";
            // 
            // AgentDetailsWithWorkingprocject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(extbtn);
            Controls.Add(vbtn);
            Controls.Add(button2);
            Controls.Add(bckbtn);
            Controls.Add(LGrid);
            Name = "AgentDetailsWithWorkingprocject";
            Text = "AgentDetailsWithWorkingprocject";
            ((System.ComponentModel.ISupportInitialize)LGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button extbtn;
        private Button vbtn;
        private Button button2;
        private Button bckbtn;
        private DataGridView LGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn DEPARTMENT_NAME;
    }
}