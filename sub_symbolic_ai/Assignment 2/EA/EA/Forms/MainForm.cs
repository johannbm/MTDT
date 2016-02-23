using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EA
{
    public partial class MainForm : Form
    {

        private EA ea { get; set; }

        private FitnessCalculator fitnessCalculator { get; set; }
        private ParentSelectionStrategy parentSelection { get; set; }
        private List<Individual> population { get; set; }
        private double maxFitness { get; set; }
        private int genotypeLength { get; set; }


        public MainForm()
        {
            InitializeComponent();
            //problemComboBox.SelectedIndex = 0;
            adultSelectionComboBox.SelectedIndex = 0;
            parentSelectorComboBox.SelectedIndex = 0;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            errorChart.Series["Best Individual"].Points.Clear();
            errorChart.Series["Population Average"].Points.Clear();

            //errorChart.Series["Population Average"].YValuesPerPoint = 3;
            errorChart.ChartAreas[0].AxisX.IsMarginVisible = false;
            errorChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            errorChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

            errorChart.ChartAreas[0].AxisX.Minimum = 0;
            errorChart.ChartAreas[0].AxisX.Maximum = (double)generationsInput.Value;
            if (maxFitness > 0)
                errorChart.ChartAreas[0].AxisY.Maximum = maxFitness;





            //Build EA
            ea = new EA();

            ea.population = GeneratePopulation();
            ea.maxFitness = this.maxFitness;
            ea.fitnessCalculator = this.fitnessCalculator;
            ea.maxNumOfGenerations = (int)generationsInput.Value;
            ea.mutationRate = (double)mutationRateInput.Value;
            ea.crossOverRate = (double)crossoverRateInput.Value;
            ea.adultPopulation = (int)adultPopulationInput.Value;
            ea.childPopulation = (int)childPopulationInput.Value;
            ea.developmentMethod = GetDevelopmentMethod();
            ea.adultSelectionStrategy = GetAdultSelectionStrategy();
            ea.parentSelectionStrategy = this.parentSelection;
            ea.geneticOperators = GetGeneticOperator();

            startButton.Enabled = false;
            stopButton.Enabled = true;
            eaBackgroundWorker.RunWorkerAsync(ea);

        }

        private IGeneticOperators GetGeneticOperator()
        {
            switch (problemComboBox.SelectedItem.ToString())
            {
                case "OneMax":
                    return new BinaryGeneticOperator();
                case "LOLZ":
                    return new BinaryGeneticOperator();
                case "Surprising Sequences":
                    return new SymbolGeneticOperator();
            }

            return null;
        }

        private DevelopmentMethod GetDevelopmentMethod()
        {
            switch (problemComboBox.SelectedItem.ToString())
            {
                case "OneMax":
                    return new BinaryDevelopment();
                case "LOLZ":
                    return new BinaryDevelopment();
                case "Surprising Sequences":
                    return new SymbolDevelopment();
            }

            return null;
        }

        private IAdultSelectionStrategy GetAdultSelectionStrategy()
        {
            switch (adultSelectionComboBox.SelectedItem.ToString())
            {
                case "Full Replacement":
                    return new FullGenerationalReplacement();
                case "Mixing":
                    return new GenerationalMixing();
                case "Overproduction":
                    return new OverProduction();
            }

            return null;
        }

        

        

        private void problemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (problemComboBox.SelectedItem.ToString()) {

                case "OneMax":
                    using (var form = new OneMaxProblemForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            this.fitnessCalculator = new OneMaxFitnessCalculator(form.bitString);

                            this.maxFitness = form.bitStringLength;
                            this.genotypeLength = form.bitStringLength;

                            string s = "Problem One Max\r\n";
                            s += "Bit size: " + form.bitStringLength + "\r\n";
                            s += "Target string: ";
                            foreach (int i in form.bitString)
                            {
                                s += i.ToString();
                            }
                            problemInfoTextBox.Text = s;
                        }
                    }
                    break;

                case "LOLZ":
                    using (var form = new LOLZForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            this.fitnessCalculator = new LOLZFitnessCalculator(form.zeroLimit);

                            this.maxFitness = form.stringLength;
                            this.genotypeLength = form.stringLength;

                            string s = "Problem LOLZ\r\n";
                            s += "Bit size: " + form.stringLength + "\r\n";
                            s += "Zero limit: " + form.zeroLimit;
                            
                            problemInfoTextBox.Text = s;
                        }
                    }
                    break;

                case "Surprising Sequences":
                    using (var form = new SurprisingSequencesForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            this.fitnessCalculator = new SSCalculator(form.ssType);

                            this.maxFitness = 1;
                            SymbolIndividual.symbolSize = form.symbolSize;
                            this.genotypeLength = form.length;

                            string s = "Surprising Sequences\r\n";
                            s += "Length target: " + form.length + "\r\n";
                            s += "Symbol set size: " + form.symbolSize + "\r\n";
                            s += form.ssType.ToString();

                            problemInfoTextBox.Text = s;
                        }
                    }
                    break;
            }

        }

        private List<Individual> GeneratePopulation()
        {
            List<Individual> population = new List<Individual>();

            switch (problemComboBox.SelectedItem.ToString())
            {

                case "OneMax":

                    for (int i = 0; i < initialPopulationInput.Value; i++)
                    {
                        population.Add(new BinaryIndividual(genotypeLength));
                    }

                    break;

                case "LOLZ":

                    for (int i = 0; i < initialPopulationInput.Value; i++)
                    {
                        population.Add(new BinaryIndividual(genotypeLength));
                    }

                   break;

                case "Surprising Sequences":

                    for (int i = 0; i < initialPopulationInput.Value; i++)
                    {
                        population.Add(new SymbolIndividual(genotypeLength));
                    }

                    break;


            }

            return population;
        }

        private void parentSelectorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (parentSelectorComboBox.SelectedItem.ToString())
            {
                case "Fitness Proportionate":
                    parentSelection = new FitnessProportionateSelection();
                    break;

                case "Sigma":
                    parentSelection = new SigmaScalingSelection();
                    break;

                case "Boltzmann":
                    using (var form = new BoltzmannForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                            this.parentSelection = new BoltzmannScalingSelection(form.temperature);
                    }
                    break;

                case "Tournament":
                    using (var form = new TournamentForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                            this.parentSelection = new TournamentSelection(form.groupSize, form.winningProbability);
                    }
                    break;
            }
        }

        private void eaBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = ((EA)e.Argument).Run(eaBackgroundWorker);
        }

        private void eaBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            GenerationLog eaLog = e.UserState as GenerationLog;

            if (eaLog.generation > errorChart.ChartAreas[0].AxisX.Maximum)
            {
                errorChart.ChartAreas[0].AxisX.Maximum = eaLog.generation;
            }

            errorChart.Series["Population Average"].Points.AddXY(eaLog.generation, eaLog.avgFitness,
                                                                 eaLog.avgFitness - eaLog.std,
                                                                 eaLog.avgFitness + eaLog.std);
            errorChart.Series["Best Individual"].Points.AddXY(eaLog.generation, eaLog.bestFitness);
        }


        private void eaBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            if (!e.Cancelled && e.Result != null)
            {
                AddEaRunEntry(e.Result as EALog);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            eaBackgroundWorker.CancelAsync();
        }

        public void AddEaRunEntry(EALog log)
        {
            ListViewItem lvi = new ListViewItem(log.ID.ToString());
            lvi.SubItems.Add(log.numberOfGens.ToString());
            lvi.SubItems.Add(log.time.ToString());
            lvi.Tag = log;

            logListView.Items.Add(lvi);
        }

        private void showRunButton_Click(object sender, EventArgs e)
        {

            ShowRunForm swf = new ShowRunForm(((EALog)logListView.SelectedItems[0].Tag).generationLog);
            swf.ShowDialog();
        }

        private void logListView_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            avgGenerationsLabel.Text = "";

            Console.WriteLine("#selected: " + logListView.SelectedItems.Count);
            if (e.IsSelected)
            {
                if (logListView.SelectedItems.Count > 1)
                {
                    List<EALog> logs = new List<EALog>();
                    for (int i = 0; i < logListView.SelectedItems.Count; i++)
                    {
                        logs.Add(logListView.SelectedItems[i].Tag as EALog);
                    }
                    ShowMultpleGraphs(logs);
                }
                else
                { 
                    ShowGraph(logListView.SelectedItems[0].Tag as EALog);
                }
            }
        }

        private void ShowGraph(EALog ealog)
        {
            
            errorChart.Series["Best Individual"].Points.Clear();
            errorChart.Series["Population Average"].Points.Clear();

            for (int i = 0; i < ealog.generationLog.Count; i++)
            {
                GenerationLog gl = ealog.generationLog[i];
                errorChart.Series["Best Individual"].Points.AddXY(i, gl.bestFitness);
                errorChart.Series["Population Average"].Points.AddXY(i, gl.avgFitness, gl.avgFitness - gl.std, gl.avgFitness + gl.std);
            }
        }

        private void ShowMultpleGraphs(List<EALog> ealogs)
        {
            if (ealogs.Count == 0)
                return;

            Console.WriteLine(errorChart.Series["Best Individual"].Color);
            errorChart.Series["Best Individual"].Points.Clear();
            errorChart.Series["Population Average"].Points.Clear();

            

            Console.WriteLine("number of series: " + errorChart.Series.Count);

            int length = errorChart.Series.Count;

            // Remove old series
            for (int i = 2; i < length; i++)
            {
                errorChart.Series.RemoveAt(2);
            }

            double avgGenerations = ealogs.Sum(x => x.numberOfGens) / ealogs.Count;
            avgGenerationsLabel.Text = "Average number of Generations: " + avgGenerations.ToString();


            Console.WriteLine("number of series: " + errorChart.Series.Count);

            for (int i = 0; i < ealogs.Count; i++)
            {
                errorChart.Series.Add(i.ToString());
                errorChart.Series[i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                errorChart.Series[i.ToString()].Color = Color.DarkBlue;
                errorChart.Series[i.ToString()].IsVisibleInLegend = false;


                for (int j = 0; j < ealogs[i].generationLog.Count; j++)
                {
                    GenerationLog gl = ealogs[i].generationLog[j];
                    errorChart.Series[i.ToString()].Points.AddXY(j, gl.bestFitness);
                    //errorChart.Series["Population Average"].Points.AddXY(i, gl.avgFitness, gl.avgFitness - gl.std, gl.avgFitness + gl.std);
                }
            }
        }

        //private void ShowGraphAverage(List<EALog> logs)
        //{
        //    errorChart.Series["Best Individual"].Points.Clear();
        //    errorChart.Series["Population Average"].Points.Clear();

        //    for (int i = 0; i < logs[0].generationLog.Count; i++)
        //    {
        //        double bestFitness = logs.Sum(x => x.generationLog[i].bestFitness) / logs.Count;
        //        double avgFitness = logs.Sum(x => x.generationLog[i].avgFitness) / logs.Count;
        //        double std = logs.Sum(x => x.generationLog[i].std) / logs.Count;

        //        errorChart.Series["Best Individual"].Points.AddXY(i, bestFitness);
        //        errorChart.Series["Population Average"].Points.AddXY(i, avgFitness, avgFitness - std, avgFitness + std);
        //    }
        //}
    }
}
