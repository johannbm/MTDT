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
    public partial class SurprisingSequencesForm : Form
    {

        public int length { get; set; }
        public int symbolSize { get; set; }
        public SSTypes ssType { get; set; }

        public SurprisingSequencesForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            length = (int)lengthUpDown.Value;
            symbolSize = (int)symbolSizeUpDown.Value;
            ssType = (globalRadioButton.Checked) ? SSTypes.Global : SSTypes.Local;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
