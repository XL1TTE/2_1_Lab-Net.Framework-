namespace _2_1Lab_Net.Framework_.WinForms
{
    partial class StudentListForm
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
            this.ViewChangePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ViewChangePanel
            // 
            this.ViewChangePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewChangePanel.Location = new System.Drawing.Point(0, 0);
            this.ViewChangePanel.Name = "ViewChangePanel";
            this.ViewChangePanel.Size = new System.Drawing.Size(800, 553);
            this.ViewChangePanel.TabIndex = 0;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.ViewChangePanel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "StudentListForm";
            this.Text = "StudentListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ViewChangePanel;
    }
}