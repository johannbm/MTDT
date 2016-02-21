namespace EA
{
    partial class LOLZForm
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
            this.bitSizeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.limitNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // bitSizeLabel
            // 
            this.bitSizeLabel.AutoSize = true;
            this.bitSizeLabel.Location = new System.Drawing.Point(41, 77);
            this.bitSizeLabel.Name = "bitSizeLabel";
            this.bitSizeLabel.Size = new System.Drawing.Size(70, 13);
            this.bitSizeLabel.TabIndex = 0;
            this.bitSizeLabel.Text = "String Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zero Limit";
            // 
            // lengthNumeric
            // 
            this.lengthNumeric.Location = new System.Drawing.Point(117, 75);
            this.lengthNumeric.Name = "lengthNumeric";
            this.lengthNumeric.Size = new System.Drawing.Size(72, 20);
            this.lengthNumeric.TabIndex = 2;
            // 
            // limitNumeric
            // 
            this.limitNumeric.Location = new System.Drawing.Point(117, 101);
            this.limitNumeric.Name = "limitNumeric";
            this.limitNumeric.Size = new System.Drawing.Size(72, 20);
            this.limitNumeric.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(78, 146);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // LOLZForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 198);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.limitNumeric);
            this.Controls.Add(this.lengthNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bitSizeLabel);
            this.Name = "LOLZForm";
            this.Text = "LOLZForm";
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bitSizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lengthNumeric;
        private System.Windows.Forms.NumericUpDown limitNumeric;
        private System.Windows.Forms.Button saveButton;
    }
}