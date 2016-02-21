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
    public partial class BoltzmannForm : Form
    {

        public double temperature { get; set; }

        public BoltzmannForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.temperature = (double)tempUpDown.Value;
            Close();
        }
    }
}
