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
    public partial class OneMaxProblemForm : Form
    {
        public int[] bitString { get; set; }
        public int bitStringLength { get; set; }

        private char[] legalCharacters = new char[] { '1', '2' };

        public OneMaxProblemForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bitStringLength = bitStringTextInput.Text.Length;
            bitString = new int[bitStringLength];
            for (int i = 0; i < bitStringLength; i++)
            {
                bitString[i] = (int)char.GetNumericValue(bitStringTextInput.Text[i]);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void bitStringTextInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validKeys = new[] { Keys.Back, Keys.D0, Keys.D1 };
            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }

        private void bitSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (bitSizeNumericUpDown.Value > bitStringTextInput.Text.Length) {
                for (int i = bitStringTextInput.Text.Length; i < bitSizeNumericUpDown.Value; i++)
                {
                    bitStringTextInput.Text += "1";
                }
            }
        }
    }
}
