namespace _2_1Lab_Net.Framework_.WinForms.Controls
{
    partial class StudentTableView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentTable = new System.Windows.Forms.DataGridView();
            this.StudentFormPanel = new System.Windows.Forms.Panel();
            this.StudentSpecialityBox = new System.Windows.Forms.TextBox();
            this.StudentGroupBox = new System.Windows.Forms.TextBox();
            this.StudentNameBox = new System.Windows.Forms.TextBox();
            this.StudentSpecialityLabel = new System.Windows.Forms.Label();
            this.StudentGroupLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.UpdateStudentButton = new System.Windows.Forms.Button();
            this.GoToGraphicButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTable)).BeginInit();
            this.StudentFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.StudentTable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 602);
            this.panel1.TabIndex = 0;
            // 
            // StudentTable
            // 
            this.StudentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentTable.Location = new System.Drawing.Point(0, 0);
            this.StudentTable.MultiSelect = false;
            this.StudentTable.Name = "StudentTable";
            this.StudentTable.ReadOnly = true;
            this.StudentTable.RowHeadersWidth = 51;
            this.StudentTable.RowTemplate.Height = 24;
            this.StudentTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentTable.Size = new System.Drawing.Size(633, 602);
            this.StudentTable.TabIndex = 0;
            this.StudentTable.SelectionChanged += new System.EventHandler(this.SelectedStudentChangedHandler);
            // 
            // StudentFormPanel
            // 
            this.StudentFormPanel.Controls.Add(this.GoToGraphicButton);
            this.StudentFormPanel.Controls.Add(this.UpdateStudentButton);
            this.StudentFormPanel.Controls.Add(this.StudentSpecialityBox);
            this.StudentFormPanel.Controls.Add(this.StudentGroupBox);
            this.StudentFormPanel.Controls.Add(this.StudentNameBox);
            this.StudentFormPanel.Controls.Add(this.StudentSpecialityLabel);
            this.StudentFormPanel.Controls.Add(this.StudentGroupLabel);
            this.StudentFormPanel.Controls.Add(this.StudentNameLabel);
            this.StudentFormPanel.Controls.Add(this.DeleteStudentButton);
            this.StudentFormPanel.Controls.Add(this.AddStudentButton);
            this.StudentFormPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StudentFormPanel.Location = new System.Drawing.Point(639, 0);
            this.StudentFormPanel.Name = "StudentFormPanel";
            this.StudentFormPanel.Size = new System.Drawing.Size(211, 602);
            this.StudentFormPanel.TabIndex = 1;
            // 
            // StudentSpecialityBox
            // 
            this.StudentSpecialityBox.Location = new System.Drawing.Point(24, 268);
            this.StudentSpecialityBox.Name = "StudentSpecialityBox";
            this.StudentSpecialityBox.Size = new System.Drawing.Size(167, 22);
            this.StudentSpecialityBox.TabIndex = 7;
            // 
            // StudentGroupBox
            // 
            this.StudentGroupBox.Location = new System.Drawing.Point(24, 221);
            this.StudentGroupBox.Name = "StudentGroupBox";
            this.StudentGroupBox.Size = new System.Drawing.Size(167, 22);
            this.StudentGroupBox.TabIndex = 6;
            // 
            // StudentNameBox
            // 
            this.StudentNameBox.Location = new System.Drawing.Point(24, 172);
            this.StudentNameBox.Name = "StudentNameBox";
            this.StudentNameBox.Size = new System.Drawing.Size(167, 22);
            this.StudentNameBox.TabIndex = 5;
            // 
            // StudentSpecialityLabel
            // 
            this.StudentSpecialityLabel.AutoSize = true;
            this.StudentSpecialityLabel.Location = new System.Drawing.Point(21, 246);
            this.StudentSpecialityLabel.Name = "StudentSpecialityLabel";
            this.StudentSpecialityLabel.Size = new System.Drawing.Size(175, 16);
            this.StudentSpecialityLabel.TabIndex = 4;
            this.StudentSpecialityLabel.Text = "Специализация студента";
            // 
            // StudentGroupLabel
            // 
            this.StudentGroupLabel.AutoSize = true;
            this.StudentGroupLabel.Location = new System.Drawing.Point(21, 202);
            this.StudentGroupLabel.Name = "StudentGroupLabel";
            this.StudentGroupLabel.Size = new System.Drawing.Size(118, 16);
            this.StudentGroupLabel.TabIndex = 3;
            this.StudentGroupLabel.Text = "Группа студента";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(21, 153);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(97, 16);
            this.StudentNameLabel.TabIndex = 2;
            this.StudentNameLabel.Text = "Имя студента";
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.AutoSize = true;
            this.DeleteStudentButton.Location = new System.Drawing.Point(116, 306);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(75, 26);
            this.DeleteStudentButton.TabIndex = 1;
            this.DeleteStudentButton.Text = "Удалить";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.AutoSize = true;
            this.AddStudentButton.Location = new System.Drawing.Point(21, 306);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(80, 26);
            this.AddStudentButton.TabIndex = 0;
            this.AddStudentButton.Text = "Добавить";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // UpdateStudentButton
            // 
            this.UpdateStudentButton.AutoSize = true;
            this.UpdateStudentButton.Location = new System.Drawing.Point(69, 338);
            this.UpdateStudentButton.Name = "UpdateStudentButton";
            this.UpdateStudentButton.Size = new System.Drawing.Size(82, 26);
            this.UpdateStudentButton.TabIndex = 8;
            this.UpdateStudentButton.Text = "Изменить";
            this.UpdateStudentButton.UseVisualStyleBackColor = true;
            this.UpdateStudentButton.Click += new System.EventHandler(this.UpdateStudentButton_Click);
            // 
            // GoToGraphicButton
            // 
            this.GoToGraphicButton.AutoSize = true;
            this.GoToGraphicButton.Location = new System.Drawing.Point(69, 370);
            this.GoToGraphicButton.Name = "GoToGraphicButton";
            this.GoToGraphicButton.Size = new System.Drawing.Size(84, 26);
            this.GoToGraphicButton.TabIndex = 9;
            this.GoToGraphicButton.Text = "К графику";
            this.GoToGraphicButton.UseVisualStyleBackColor = true;
            this.GoToGraphicButton.Click += new System.EventHandler(this.GoToGraphicButton_Click);
            // 
            // StudentTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentFormPanel);
            this.Controls.Add(this.panel1);
            this.Name = "StudentTableView";
            this.Size = new System.Drawing.Size(850, 602);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentTable)).EndInit();
            this.StudentFormPanel.ResumeLayout(false);
            this.StudentFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView StudentTable;
        private System.Windows.Forms.Panel StudentFormPanel;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label StudentGroupLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label StudentSpecialityLabel;
        private System.Windows.Forms.TextBox StudentSpecialityBox;
        private System.Windows.Forms.TextBox StudentGroupBox;
        private System.Windows.Forms.TextBox StudentNameBox;
        private System.Windows.Forms.Button UpdateStudentButton;
        private System.Windows.Forms.Button GoToGraphicButton;
    }
}
