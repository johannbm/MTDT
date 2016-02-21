namespace EA
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.problemComboBox = new System.Windows.Forms.ComboBox();
            this.problemLabel = new System.Windows.Forms.Label();
            this.adultSelectionLabel = new System.Windows.Forms.Label();
            this.adultSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.parentSelectionLabel = new System.Windows.Forms.Label();
            this.parentSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.errorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mutationRateLabel = new System.Windows.Forms.Label();
            this.crossoverRateLabel = new System.Windows.Forms.Label();
            this.mutationRateInput = new System.Windows.Forms.NumericUpDown();
            this.crossoverRateInput = new System.Windows.Forms.NumericUpDown();
            this.initialPopulationLabel = new System.Windows.Forms.Label();
            this.adultPopulationLabel = new System.Windows.Forms.Label();
            this.childPopulationLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.generationsInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.childPopulationInput = new System.Windows.Forms.NumericUpDown();
            this.adultPopulationInput = new System.Windows.Forms.NumericUpDown();
            this.initialPopulationInput = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.eaBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRateInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossoverRateInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generationsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childPopulationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultPopulationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPopulationInput)).BeginInit();
            this.SuspendLayout();
            // 
            // problemComboBox
            // 
            this.problemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.problemComboBox.FormattingEnabled = true;
            this.problemComboBox.Items.AddRange(new object[] {
            "OneMax",
            "LOLZ",
            "Surprising Sequences"});
            this.problemComboBox.Location = new System.Drawing.Point(106, 30);
            this.problemComboBox.Name = "problemComboBox";
            this.problemComboBox.Size = new System.Drawing.Size(121, 21);
            this.problemComboBox.TabIndex = 0;
            this.problemComboBox.SelectedIndexChanged += new System.EventHandler(this.problemComboBox_SelectedIndexChanged);
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Location = new System.Drawing.Point(6, 30);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(45, 13);
            this.problemLabel.TabIndex = 1;
            this.problemLabel.Text = "Problem";
            // 
            // adultSelectionLabel
            // 
            this.adultSelectionLabel.AutoSize = true;
            this.adultSelectionLabel.Location = new System.Drawing.Point(6, 61);
            this.adultSelectionLabel.Name = "adultSelectionLabel";
            this.adultSelectionLabel.Size = new System.Drawing.Size(78, 13);
            this.adultSelectionLabel.TabIndex = 3;
            this.adultSelectionLabel.Text = "Adult Selection";
            // 
            // adultSelectionComboBox
            // 
            this.adultSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adultSelectionComboBox.FormattingEnabled = true;
            this.adultSelectionComboBox.Items.AddRange(new object[] {
            "Full Replacement",
            "Mixing",
            "Overproduction"});
            this.adultSelectionComboBox.Location = new System.Drawing.Point(106, 57);
            this.adultSelectionComboBox.Name = "adultSelectionComboBox";
            this.adultSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.adultSelectionComboBox.TabIndex = 2;
            // 
            // parentSelectionLabel
            // 
            this.parentSelectionLabel.AutoSize = true;
            this.parentSelectionLabel.Location = new System.Drawing.Point(6, 93);
            this.parentSelectionLabel.Name = "parentSelectionLabel";
            this.parentSelectionLabel.Size = new System.Drawing.Size(85, 13);
            this.parentSelectionLabel.TabIndex = 5;
            this.parentSelectionLabel.Text = "Parent Selection";
            // 
            // parentSelectorComboBox
            // 
            this.parentSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentSelectorComboBox.FormattingEnabled = true;
            this.parentSelectorComboBox.Items.AddRange(new object[] {
            "Fitness Proportionate",
            "Sigma",
            "Boltzmann",
            "Tournament"});
            this.parentSelectorComboBox.Location = new System.Drawing.Point(106, 90);
            this.parentSelectorComboBox.Name = "parentSelectorComboBox";
            this.parentSelectorComboBox.Size = new System.Drawing.Size(121, 21);
            this.parentSelectorComboBox.TabIndex = 4;
            this.parentSelectorComboBox.SelectedIndexChanged += new System.EventHandler(this.parentSelectorComboBox_SelectedIndexChanged);
            // 
            // errorChart
            // 
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Generations";
            chartArea1.AxisY.Title = "Fitness";
            chartArea1.Name = "ChartArea1";
            this.errorChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.errorChart.Legends.Add(legend1);
            this.errorChart.Location = new System.Drawing.Point(38, 276);
            this.errorChart.Name = "errorChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Best Individual";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.errorChart.Series.Add(series1);
            this.errorChart.Size = new System.Drawing.Size(975, 300);
            this.errorChart.TabIndex = 6;
            this.errorChart.Text = "chart1";
            // 
            // mutationRateLabel
            // 
            this.mutationRateLabel.AutoSize = true;
            this.mutationRateLabel.Location = new System.Drawing.Point(200, 30);
            this.mutationRateLabel.Name = "mutationRateLabel";
            this.mutationRateLabel.Size = new System.Drawing.Size(74, 13);
            this.mutationRateLabel.TabIndex = 7;
            this.mutationRateLabel.Text = "Mutation Rate";
            // 
            // crossoverRateLabel
            // 
            this.crossoverRateLabel.AutoSize = true;
            this.crossoverRateLabel.Location = new System.Drawing.Point(200, 62);
            this.crossoverRateLabel.Name = "crossoverRateLabel";
            this.crossoverRateLabel.Size = new System.Drawing.Size(80, 13);
            this.crossoverRateLabel.TabIndex = 8;
            this.crossoverRateLabel.Text = "Crossover Rate";
            // 
            // mutationRateInput
            // 
            this.mutationRateInput.DecimalPlaces = 5;
            this.mutationRateInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.mutationRateInput.Location = new System.Drawing.Point(290, 28);
            this.mutationRateInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutationRateInput.Name = "mutationRateInput";
            this.mutationRateInput.Size = new System.Drawing.Size(89, 20);
            this.mutationRateInput.TabIndex = 9;
            this.mutationRateInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // crossoverRateInput
            // 
            this.crossoverRateInput.DecimalPlaces = 5;
            this.crossoverRateInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.crossoverRateInput.Location = new System.Drawing.Point(290, 60);
            this.crossoverRateInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crossoverRateInput.Name = "crossoverRateInput";
            this.crossoverRateInput.Size = new System.Drawing.Size(89, 20);
            this.crossoverRateInput.TabIndex = 10;
            this.crossoverRateInput.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // initialPopulationLabel
            // 
            this.initialPopulationLabel.AutoSize = true;
            this.initialPopulationLabel.Location = new System.Drawing.Point(6, 33);
            this.initialPopulationLabel.Name = "initialPopulationLabel";
            this.initialPopulationLabel.Size = new System.Drawing.Size(84, 13);
            this.initialPopulationLabel.TabIndex = 11;
            this.initialPopulationLabel.Text = "Initial Population";
            // 
            // adultPopulationLabel
            // 
            this.adultPopulationLabel.AutoSize = true;
            this.adultPopulationLabel.Location = new System.Drawing.Point(6, 61);
            this.adultPopulationLabel.Name = "adultPopulationLabel";
            this.adultPopulationLabel.Size = new System.Drawing.Size(84, 13);
            this.adultPopulationLabel.TabIndex = 12;
            this.adultPopulationLabel.Text = "Adult Population";
            // 
            // childPopulationLabel
            // 
            this.childPopulationLabel.AutoSize = true;
            this.childPopulationLabel.Location = new System.Drawing.Point(6, 93);
            this.childPopulationLabel.Name = "childPopulationLabel";
            this.childPopulationLabel.Size = new System.Drawing.Size(83, 13);
            this.childPopulationLabel.TabIndex = 13;
            this.childPopulationLabel.Text = "Child Population";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parentSelectorComboBox);
            this.groupBox1.Controls.Add(this.adultSelectionComboBox);
            this.groupBox1.Controls.Add(this.problemLabel);
            this.groupBox1.Controls.Add(this.adultSelectionLabel);
            this.groupBox1.Controls.Add(this.parentSelectionLabel);
            this.groupBox1.Controls.Add(this.problemComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 124);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EA Components";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generationsInput);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.childPopulationInput);
            this.groupBox2.Controls.Add(this.adultPopulationInput);
            this.groupBox2.Controls.Add(this.crossoverRateInput);
            this.groupBox2.Controls.Add(this.initialPopulationInput);
            this.groupBox2.Controls.Add(this.mutationRateInput);
            this.groupBox2.Controls.Add(this.childPopulationLabel);
            this.groupBox2.Controls.Add(this.initialPopulationLabel);
            this.groupBox2.Controls.Add(this.adultPopulationLabel);
            this.groupBox2.Controls.Add(this.mutationRateLabel);
            this.groupBox2.Controls.Add(this.crossoverRateLabel);
            this.groupBox2.Location = new System.Drawing.Point(251, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 124);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EA Parameters";
            // 
            // generationsInput
            // 
            this.generationsInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.generationsInput.Location = new System.Drawing.Point(290, 91);
            this.generationsInput.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.generationsInput.Name = "generationsInput";
            this.generationsInput.Size = new System.Drawing.Size(89, 20);
            this.generationsInput.TabIndex = 18;
            this.generationsInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Generations";
            // 
            // childPopulationInput
            // 
            this.childPopulationInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.childPopulationInput.Location = new System.Drawing.Point(95, 93);
            this.childPopulationInput.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.childPopulationInput.Name = "childPopulationInput";
            this.childPopulationInput.Size = new System.Drawing.Size(99, 20);
            this.childPopulationInput.TabIndex = 16;
            this.childPopulationInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // adultPopulationInput
            // 
            this.adultPopulationInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.adultPopulationInput.Location = new System.Drawing.Point(96, 59);
            this.adultPopulationInput.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.adultPopulationInput.Name = "adultPopulationInput";
            this.adultPopulationInput.Size = new System.Drawing.Size(98, 20);
            this.adultPopulationInput.TabIndex = 15;
            this.adultPopulationInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // initialPopulationInput
            // 
            this.initialPopulationInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.initialPopulationInput.Location = new System.Drawing.Point(96, 28);
            this.initialPopulationInput.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.initialPopulationInput.Name = "initialPopulationInput";
            this.initialPopulationInput.Size = new System.Drawing.Size(98, 20);
            this.initialPopulationInput.TabIndex = 14;
            this.initialPopulationInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(38, 227);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // eaBackgroundWorker
            // 
            this.eaBackgroundWorker.WorkerReportsProgress = true;
            this.eaBackgroundWorker.WorkerSupportsCancellation = true;
            this.eaBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.eaBackgroundWorker_DoWork);
            this.eaBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.eaBackgroundWorker_ProgressChanged);
            this.eaBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.eaBackgroundWorker_RunWorkerCompleted);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(119, 227);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 609);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.errorChart);
            this.Name = "MainForm";
            this.Text = "Evolutionary Algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.errorChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutationRateInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossoverRateInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generationsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childPopulationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultPopulationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPopulationInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox problemComboBox;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.Label adultSelectionLabel;
        private System.Windows.Forms.ComboBox adultSelectionComboBox;
        private System.Windows.Forms.Label parentSelectionLabel;
        private System.Windows.Forms.ComboBox parentSelectorComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart errorChart;
        private System.Windows.Forms.Label mutationRateLabel;
        private System.Windows.Forms.Label crossoverRateLabel;
        private System.Windows.Forms.NumericUpDown mutationRateInput;
        private System.Windows.Forms.NumericUpDown crossoverRateInput;
        private System.Windows.Forms.Label initialPopulationLabel;
        private System.Windows.Forms.Label adultPopulationLabel;
        private System.Windows.Forms.Label childPopulationLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown childPopulationInput;
        private System.Windows.Forms.NumericUpDown adultPopulationInput;
        private System.Windows.Forms.NumericUpDown initialPopulationInput;
        private System.Windows.Forms.NumericUpDown generationsInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker eaBackgroundWorker;
        private System.Windows.Forms.Button stopButton;
    }
}