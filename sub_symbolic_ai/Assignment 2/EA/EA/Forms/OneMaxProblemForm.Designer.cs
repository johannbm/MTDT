namespace EA
{
    partial class OneMaxProblemForm
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
            this.bitSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bitStringTextInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bitSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bitSizeNumericUpDown
            // 
            this.bitSizeNumericUpDown.Location = new System.Drawing.Point(52, 75);
            this.bitSizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bitSizeNumericUpDown.Name = "bitSizeNumericUpDown";
            this.bitSizeNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.bitSizeNumericUpDown.TabIndex = 0;
            this.bitSizeNumericUpDown.ValueChanged += new System.EventHandler(this.bitSizeNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bits";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(88, 184);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "String";
            // 
            // bitStringTextInput
            // 
            this.bitStringTextInput.Location = new System.Drawing.Point(52, 120);
            this.bitStringTextInput.Name = "bitStringTextInput";
            this.bitStringTextInput.Size = new System.Drawing.Size(187, 20);
            this.bitStringTextInput.TabIndex = 6;
            this.bitStringTextInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bitStringTextInput_KeyPress);
            // 
            // OneMaxProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 219);
            this.Controls.Add(this.bitStringTextInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitSizeNumericUpDown);
            this.Name = "OneMaxProblemForm";
            this.Text = "OneMaxProblemForm";
            ((System.ComponentModel.ISupportInitialize)(this.bitSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown bitSizeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bitStringTextInput;
    }
}