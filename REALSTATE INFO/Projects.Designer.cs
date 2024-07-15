namespace RealState_Project
{
    partial class Projects
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
            jGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            exitbtn = new Button();
            PNEE = new TextBox();
            PIDE = new TextBox();
            viewbtn = new Button();
            Deletebtn = new Button();
            editbtn = new Button();
            savebtn = new Button();
            C = new Label();
            LABEL1 = new Label();
            Searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)jGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(667, 16);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(369, 39);
            label2.TabIndex = 248;
            label2.Text = "PROJECTS DETAILS";
            // 
            // BACKBTN
            // 
            BACKBTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BACKBTN.Location = new Point(1175, 408);
            BACKBTN.Name = "BACKBTN";
            BACKBTN.Size = new Size(76, 31);
            BACKBTN.TabIndex = 247;
            BACKBTN.Text = "Back";
            BACKBTN.UseVisualStyleBackColor = true;
            BACKBTN.Click += BACKBTN_Click;
            // 
            // jGrid
            // 
            jGrid.AccessibleName = "";
            jGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            jGrid.Location = new Point(730, 80);
            jGrid.Name = "jGrid";
            jGrid.Size = new Size(236, 247);
            jGrid.TabIndex = 246;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "PROJECT_ID";
            Column1.HeaderText = "PROJECT ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "PROJECT_NAME";
            Column2.HeaderText = "PROJECT NAME";
            Column2.Name = "Column2";
            // 
            // exitbtn
            // 
            exitbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exitbtn.Location = new Point(1313, 408);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(75, 31);
            exitbtn.TabIndex = 240;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // PNEE
            // 
            PNEE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PNEE.Location = new Point(187, 102);
            PNEE.Name = "PNEE";
            PNEE.Size = new Size(100, 24);
            PNEE.TabIndex = 245;
            // 
            // PIDE
            // 
            PIDE.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PIDE.Location = new Point(187, 55);
            PIDE.Name = "PIDE";
            PIDE.Size = new Size(100, 24);
            PIDE.TabIndex = 241;
            // 
            // viewbtn
            // 
            viewbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            viewbtn.Location = new Point(1026, 407);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(75, 31);
            viewbtn.TabIndex = 238;
            viewbtn.Text = "View";
            viewbtn.UseVisualStyleBackColor = true;
            viewbtn.Click += viewbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebtn.Location = new Point(776, 404);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 31);
            Deletebtn.TabIndex = 237;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            editbtn.Location = new Point(626, 404);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 31);
            editbtn.TabIndex = 236;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.Location = new Point(470, 404);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(74, 31);
            savebtn.TabIndex = 235;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // C
            // 
            C.AutoSize = true;
            C.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(26, 102);
            C.Name = "C";
            C.Size = new Size(126, 18);
            C.TabIndex = 231;
            C.Text = "PROJECT NAME";
            // 
            // LABEL1
            // 
            LABEL1.AutoSize = true;
            LABEL1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LABEL1.Location = new Point(26, 58);
            LABEL1.Name = "LABEL1";
            LABEL1.Size = new Size(97, 18);
            LABEL1.TabIndex = 230;
            LABEL1.Text = "PROJECT ID";
            // 
            // Searchbtn
            // 
            Searchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Searchbtn.Location = new Point(901, 407);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 32);
            Searchbtn.TabIndex = 249;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 450);
            Controls.Add(Searchbtn);
            Controls.Add(label2);
            Controls.Add(BACKBTN);
            Controls.Add(jGrid);
            Controls.Add(exitbtn);
            Controls.Add(PNEE);
            Controls.Add(PIDE);
            Controls.Add(viewbtn);
            Controls.Add(Deletebtn);
            Controls.Add(editbtn);
            Controls.Add(savebtn);
            Controls.Add(C);
            Controls.Add(LABEL1);
            Name = "Projects";
            Text = "PROJECTS DETAILS";
            ((System.ComponentModel.ISupportInitialize)jGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button BACKBTN;
        private DataGridView jGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button exitbtn;
        private TextBox PNEE;
        private TextBox PIDE;
        private Button viewbtn;
        private Button Deletebtn;
        private Button editbtn;
        private Button savebtn;
        private Label C;
        private Label LABEL1;
        private Button Searchbtn;
    }
}
