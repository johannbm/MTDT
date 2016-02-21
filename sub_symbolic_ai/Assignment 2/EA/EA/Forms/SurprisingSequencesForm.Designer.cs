namespace EA
{
    partial class SurprisingSequencesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.symbolSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.globalRadioButton = new System.Windows.Forms.RadioButton();
            this.localRadioButton = new System.Windows.Forms.RadioButton();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolSizeUpDown)).BeginInit();
            this.typeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Symbol Size";
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Location = new System.Drawing.Point(141, 42);
            this.lengthUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lengthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(57, 20);
            this.lengthUpDown.TabIndex = 2;
            this.lengthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // symbolSizeUpDown
            // 
            this.symbolSizeUpDown.Location = new System.Drawing.Point(141, 71);
            this.symbolSizeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.symbolSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.symbolSizeUpDown.Name = "symbolSizeUpDown";
            this.symbolSizeUpDown.Size = new System.Drawing.Size(57, 20);
            this.symbolSizeUpDown.TabIndex = 3;
            this.symbolSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(95, 185);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // globalRadioButton
            // 
            this.globalRadioButton.AutoSize = true;
            this.globalRadioButton.Checked = true;
            this.globalRadioButton.Location = new System.Drawing.Point(6, 19);
            this.globalRadioButton.Name = "globalRadioButton";
            this.globalRadioButton.Size = new System.Drawing.Size(55, 17);
            this.globalRadioButton.TabIndex = 5;
            this.globalRadioButton.TabStop = true;
            this.globalRadioButton.Text = "Global";
            this.globalRadioButton.UseVisualStyleBackColor = true;
            // 
            // localRadioButton
            // 
            this.localRadioButton.AutoSize = true;
            this.localRadioButton.Location = new System.Drawing.Point(6, 42);
            this.localRadioButton.Name = "localRadioButton";
            this.localRadioButton.Size = new System.Drawing.Size(51, 17);
            this.localRadioButton.TabIndex = 6;
            this.localRadioButton.Text = "Local";
            this.localRadioButton.UseVisualStyleBackColor = true;
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.globalRadioButton);
            this.typeGroupBox.Controls.Add(this.localRadioButton);
            this.typeGroupBox.Location = new System.Drawing.Point(74, 97);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(124, 82);
            this.typeGroupBox.TabIndex = 7;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Type";
            // 
            // SurprisingSequencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.symbolSizeUpDown);
            this.Controls.Add(this.lengthUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SurprisingSequencesForm";
            this.Text = "SurprisingSequencesForm";
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolSizeUpDown)).EndInit();
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.NumericUpDown symbolSizeUpDown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton globalRadioButton;
        private System.Windows.Forms.RadioButton localRadioButton;
        private System.Windows.Forms.GroupBox typeGroupBox;
    }
}