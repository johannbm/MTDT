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
    public partial class ShowRunForm : Form
    {
        private List<GenerationLog> data { get; set; }

        public ShowRunForm(List<GenerationLog> data)
        {
            InitializeComponent();
            this.data = data;
            DisplayData();
        }


        private void DisplayData()
        {
            foreach (GenerationLog gl in data)
            {
                ListViewItem lvi = new ListViewItem(gl.generation.ToString());
                lvi.SubItems.Add(gl.bestFitness.ToString());
                lvi.SubItems.Add(gl.avgFitness.ToString());
                lvi.SubItems.Add(gl.std.ToString());
                lvi.Tag = gl.bestPhenotype;

                generationListView.Items.Add(lvi);


            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void generationListView_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                phenotypeTextbox.Text = generationListView.SelectedItems[0].Tag as string;
            }
            Console.WriteLine("changed " + e.IsSelected);
        }
    }
}
