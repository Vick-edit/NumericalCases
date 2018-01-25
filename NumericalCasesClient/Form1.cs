using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumericalCases;

namespace NumericalCasesClient
{
    public partial class Form1 : Form
    {
        private readonly INumbersToText _numbersToText;
        public Form1()
        {
            InitializeComponent();
            Case.SelectedIndex = 0;
            Gender.SelectedIndex = 0;

            _numbersToText = new NumbersToText();
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && Number.Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            Output.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number = (long) Number.Value;
            var caseVal = Case.SelectedItem.ToString();
            var genderVal = Gender.SelectedItem.ToString();

            var result = _numbersToText.sumProp(number, genderVal, caseVal);
            Output.Text = result;
        }
    }
}
