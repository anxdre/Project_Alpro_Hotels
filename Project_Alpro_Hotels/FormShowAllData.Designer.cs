namespace Project_Alpro_Hotels
{
    partial class FormShowAllData
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
            this.listBoxShowAllData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxShowAllData
            // 
            this.listBoxShowAllData.FormattingEnabled = true;
            this.listBoxShowAllData.ItemHeight = 16;
            this.listBoxShowAllData.Location = new System.Drawing.Point(35, 32);
            this.listBoxShowAllData.Name = "listBoxShowAllData";
            this.listBoxShowAllData.Size = new System.Drawing.Size(584, 292);
            this.listBoxShowAllData.TabIndex = 0;
            // 
            // FormShowAllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 362);
            this.Controls.Add(this.listBoxShowAllData);
            this.Name = "FormShowAllData";
            this.Text = "FormShowAllData";
            this.Load += new System.EventHandler(this.FormShowAllData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShowAllData;
    }
}