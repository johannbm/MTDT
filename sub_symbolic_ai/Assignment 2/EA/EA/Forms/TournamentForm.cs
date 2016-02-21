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
    public partial class TournamentForm : Form
    {

        public int groupSize { get; set; }
        public double winningProbability { get; set; }

        public TournamentForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            groupSize = (int)groupSizeUpDown.Value;
            winningProbability = (double)winProbUpDown.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
