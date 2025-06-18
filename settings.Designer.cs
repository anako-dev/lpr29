namespace lpr29
{
    partial class settings
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
            this.fontButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorPreviewPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(542, 54);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(169, 40);
            this.fontButton.TabIndex = 0;
            this.fontButton.Text = "Змінити шрифт";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(614, 343);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(132, 67);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // fontTextBox
            // 
            this.fontTextBox.Location = new System.Drawing.Point(84, 54);
            this.fontTextBox.Multiline = true;
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.ReadOnly = true;
            this.fontTextBox.Size = new System.Drawing.Size(428, 40);
            this.fontTextBox.TabIndex = 2;
            // 
            // hostTextBox
            // 
            this.hostTextBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostTextBox.Location = new System.Drawing.Point(283, 116);
            this.hostTextBox.Multiline = true;
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(428, 40);
            this.hostTextBox.TabIndex = 3;
            this.hostTextBox.Text = "235.5.5.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP-адреса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порт:";
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portNumericUpDown.Location = new System.Drawing.Point(268, 186);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(120, 32);
            this.portNumericUpDown.TabIndex = 6;
            this.portNumericUpDown.Value = new decimal(new int[] {
            8001,
            0,
            0,
            0});
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(252, 252);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(169, 40);
            this.colorButton.TabIndex = 7;
            this.colorButton.Text = "Змінити колір";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click_1);
            // 
            // colorPreviewPanel
            // 
            this.colorPreviewPanel.Location = new System.Drawing.Point(88, 252);
            this.colorPreviewPanel.Name = "colorPreviewPanel";
            this.colorPreviewPanel.Size = new System.Drawing.Size(136, 40);
            this.colorPreviewPanel.TabIndex = 8;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorPreviewPanel);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.portNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.fontTextBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fontButton);
            this.Name = "settings";
            this.Text = "settings";
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown portNumericUpDown;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Panel colorPreviewPanel;
    }
}