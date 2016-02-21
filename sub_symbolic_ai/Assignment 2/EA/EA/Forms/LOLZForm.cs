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
    public partial class LOLZForm : Form
    {

        public int stringLength { get; set; }
        public int zeroLimit { get; set; }

        public LOLZForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.stringLength = (int)lengthNumeric.Value;
            zeroLimit = (int)limitNumeric.Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
