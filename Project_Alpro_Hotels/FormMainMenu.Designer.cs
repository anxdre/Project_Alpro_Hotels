namespace Project_Alpro_Hotels
{
    partial class FormMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxHistoryData = new System.Windows.Forms.ListBox();
            this.textBoxHighData = new System.Windows.Forms.TextBox();
            this.textBoxAverageData = new System.Windows.Forms.TextBox();
            this.textBoxLowestData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.addDataToolStripMenuItem.Text = "Exit";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataToolStripMenuItem1,
            this.clearDataToolStripMenuItem1});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // addDataToolStripMenuItem1
            // 
            this.addDataToolStripMenuItem1.Name = "addDataToolStripMenuItem1";
            this.addDataToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.addDataToolStripMenuItem1.Text = "Add Data";
            this.addDataToolStripMenuItem1.Click += new System.EventHandler(this.addDataToolStripMenuItem1_Click);
            // 
            // clearDataToolStripMenuItem1
            // 
            this.clearDataToolStripMenuItem1.Name = "clearDataToolStripMenuItem1";
            this.clearDataToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.clearDataToolStripMenuItem1.Text = "Clear Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Highest Sale Data ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(51, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Sale Data ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(51, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lowest Sale Data";
            // 
            // listBoxHistoryData
            // 
            this.listBoxHistoryData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHistoryData.FormattingEnabled = true;
            this.listBoxHistoryData.ItemHeight = 16;
            this.listBoxHistoryData.Location = new System.Drawing.Point(23, 38);
            this.listBoxHistoryData.Name = "listBoxHistoryData";
            this.listBoxHistoryData.Size = new System.Drawing.Size(419, 164);
            this.listBoxHistoryData.TabIndex = 2;
            // 
            // textBoxHighData
            // 
            this.textBoxHighData.Location = new System.Drawing.Point(231, 96);
            this.textBoxHighData.Name = "textBoxHighData";
            this.textBoxHighData.Size = new System.Drawing.Size(251, 22);
            this.textBoxHighData.TabIndex = 3;
            // 
            // textBoxAverageData
            // 
            this.textBoxAverageData.Location = new System.Drawing.Point(231, 141);
            this.textBoxAverageData.Name = "textBoxAverageData";
            this.textBoxAverageData.Size = new System.Drawing.Size(251, 22);
            this.textBoxAverageData.TabIndex = 3;
            // 
            // textBoxLowestData
            // 
            this.textBoxLowestData.Location = new System.Drawing.Point(231, 187);
            this.textBoxLowestData.Name = "textBoxLowestData";
            this.textBoxLowestData.Size = new System.Drawing.Size(251, 22);
            this.textBoxLowestData.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxHistoryData);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(31, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 231);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History Transaction Data";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(534, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxLowestData);
            this.Controls.Add(this.textBoxAverageData);
            this.Controls.Add(this.textBoxHighData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxHistoryData;
        private System.Windows.Forms.TextBox textBoxHighData;
        private System.Windows.Forms.TextBox textBoxAverageData;
        private System.Windows.Forms.TextBox textBoxLowestData;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

