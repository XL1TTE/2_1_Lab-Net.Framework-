namespace _2_1Lab_Net.Framework_.WinForms.Controls
{
    partial class StudentGraphicsView
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
            this.GraphicPanel = new System.Windows.Forms.Panel();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.ToStudentTableButton = new System.Windows.Forms.Button();
            this.UpdateGraph = new System.Windows.Forms.Button();
            this.ToolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphicPanel
            // 
            this.GraphicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphicPanel.Location = new System.Drawing.Point(0, 0);
            this.GraphicPanel.Margin = new System.Windows.Forms.Padding(10);
            this.GraphicPanel.Name = "GraphicPanel";
            this.GraphicPanel.Size = new System.Drawing.Size(688, 613);
            this.GraphicPanel.TabIndex = 0;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.Controls.Add(this.UpdateGraph);
            this.ToolsPanel.Controls.Add(this.ToStudentTableButton);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToolsPanel.Location = new System.Drawing.Point(689, 0);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(196, 613);
            this.ToolsPanel.TabIndex = 1;
            // 
            // ToStudentTableButton
            // 
            this.ToStudentTableButton.AutoSize = true;
            this.ToStudentTableButton.Location = new System.Drawing.Point(65, 291);
            this.ToStudentTableButton.Name = "ToStudentTableButton";
            this.ToStudentTableButton.Size = new System.Drawing.Size(83, 26);
            this.ToStudentTableButton.TabIndex = 0;
            this.ToStudentTableButton.Text = "К таблице";
            this.ToStudentTableButton.UseVisualStyleBackColor = true;
            this.ToStudentTableButton.Click += new System.EventHandler(this.ToStudentTableButton_Click);
            // 
            // UpdateGraph
            // 
            this.UpdateGraph.AutoSize = true;
            this.UpdateGraph.Location = new System.Drawing.Point(41, 323);
            this.UpdateGraph.Name = "UpdateGraph";
            this.UpdateGraph.Size = new System.Drawing.Size(139, 26);
            this.UpdateGraph.TabIndex = 1;
            this.UpdateGraph.Text = "Обновить график";
            this.UpdateGraph.UseVisualStyleBackColor = true;
            this.UpdateGraph.Click += new System.EventHandler(this.UpdateGraph_Click);
            // 
            // StudentGraphicsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.GraphicPanel);
            this.Name = "StudentGraphicsView";
            this.Size = new System.Drawing.Size(885, 613);
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GraphicPanel;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Button ToStudentTableButton;
        private System.Windows.Forms.Button UpdateGraph;
    }
}
