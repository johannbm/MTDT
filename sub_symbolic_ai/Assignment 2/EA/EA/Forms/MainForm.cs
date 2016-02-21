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

        

        private void eaBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ((EA)e.Argument).Run(eaBackgroundWorker);
        }

        private void eaBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Tuple<int, double> eaState = (Tuple<int, double>)e.UserState;

            if (eaState.Item1 > errorChart.ChartAreas[0].AxisX.Maximum)
            {
                errorChart.ChartAreas[0].AxisX.Maximum = eaState.Item1;
            }

            errorChart.Series["Best Individual"].Points.AddXY(eaState.Item1, eaState.Item2);
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


        private void eaBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            eaBackgroundWorker.CancelAsync();
        }

    }
}
