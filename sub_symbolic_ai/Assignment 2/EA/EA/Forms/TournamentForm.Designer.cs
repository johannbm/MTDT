namespace EA
{
    partial class TournamentForm
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
            this.groupSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.winProbUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupSizeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winProbUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Win Probability";
            // 
            // groupSizeUpDown
            // 
            this.groupSizeUpDown.Location = new System.Drawing.Point(134, 42);
            this.groupSizeUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.groupSizeUpDown.Name = "groupSizeUpDown";
            this.groupSizeUpDown.Size = new System.Drawing.Size(120, 20);
            this.groupSizeUpDown.TabIndex = 2;
            this.groupSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // winProbUpDown
            // 
            this.winProbUpDown.DecimalPlaces = 4;
            this.winProbUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.winProbUpDown.Location = new System.Drawing.Point(134, 71);
            this.winProbUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.winProbUpDown.Name = "winProbUpDown";
            this.winProbUpDown.Size = new System.Drawing.Size(120, 20);
            this.winProbUpDown.TabIndex = 3;
            this.winProbUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(111, 120);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // TournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 195);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.winProbUpDown);
            this.Controls.Add(this.groupSizeUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TournamentForm";
            this.Text = "TournamentForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupSizeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winProbUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown groupSizeUpDown;
        private System.Windows.Forms.NumericUpDown winProbUpDown;
        private System.Windows.Forms.Button saveButton;
    }
}