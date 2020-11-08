namespace Project_Alpro_Hotels
{
    partial class FormAddData
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLengthStay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMemberFalse = new System.Windows.Forms.RadioButton();
            this.radioButtonMemberTrue = new System.Windows.Forms.RadioButton();
            this.listBoxDetailAddData = new System.Windows.Forms.ListBox();
            this.buttonAddData = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(195, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(302, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(195, 109);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(302, 24);
            this.comboBoxRoomType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(62, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type Of Room :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(62, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Length Of Stay : ";
            // 
            // textBoxLengthStay
            // 
            this.textBoxLengthStay.Location = new System.Drawing.Point(195, 159);
            this.textBoxLengthStay.Name = "textBoxLengthStay";
            this.textBoxLengthStay.Size = new System.Drawing.Size(302, 22);
            this.textBoxLengthStay.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMemberFalse);
            this.groupBox1.Controls.Add(this.radioButtonMemberTrue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(65, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Card";
            // 
            // radioButtonMemberFalse
            // 
            this.radioButtonMemberFalse.AutoSize = true;
            this.radioButtonMemberFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMemberFalse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMemberFalse.Location = new System.Drawing.Point(42, 87);
            this.radioButtonMemberFalse.Name = "radioButtonMemberFalse";
            this.radioButtonMemberFalse.Size = new System.Drawing.Size(47, 21);
            this.radioButtonMemberFalse.TabIndex = 0;
            this.radioButtonMemberFalse.TabStop = true;
            this.radioButtonMemberFalse.Text = "No";
            this.radioButtonMemberFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonMemberTrue
            // 
            this.radioButtonMemberTrue.AutoSize = true;
            this.radioButtonMemberTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMemberTrue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMemberTrue.Location = new System.Drawing.Point(42, 44);
            this.radioButtonMemberTrue.Name = "radioButtonMemberTrue";
            this.radioButtonMemberTrue.Size = new System.Drawing.Size(53, 21);
            this.radioButtonMemberTrue.TabIndex = 0;
            this.radioButtonMemberTrue.TabStop = true;
            this.radioButtonMemberTrue.Text = "Yes";
            this.radioButtonMemberTrue.UseVisualStyleBackColor = true;
            // 
            // listBoxDetailAddData
            // 
            this.listBoxDetailAddData.FormattingEnabled = true;
            this.listBoxDetailAddData.ItemHeight = 16;
            this.listBoxDetailAddData.Location = new System.Drawing.Point(65, 444);
            this.listBoxDetailAddData.Name = "listBoxDetailAddData";
            this.listBoxDetailAddData.Size = new System.Drawing.Size(431, 164);
            this.listBoxDetailAddData.TabIndex = 5;
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(403, 378);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(93, 33);
            this.buttonAddData.TabIndex = 4;
            this.buttonAddData.Text = "Add";
            this.buttonAddData.UseVisualStyleBackColor = true;
            this.buttonAddData.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(409, 631);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(87, 35);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(65, 631);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 35);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(573, 703);
            this.Controls.Add(this.listBoxDetailAddData);
            this.Controls.Add(this.buttonAddData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.textBoxLengthStay);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddData";
            this.Text = "Add Data";
            this.Load += new System.EventHandler(this.FormAddData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLengthStay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMemberFalse;
        private System.Windows.Forms.RadioButton radioButtonMemberTrue;
        private System.Windows.Forms.ListBox listBoxDetailAddData;
        private System.Windows.Forms.Button buttonAddData;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}