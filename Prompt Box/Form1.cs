using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prompt_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addHoldingButton_Click(object sender, EventArgs e)
        {
            string ticker = tickerNameTextBox.Text;
            string shares = numShareTextBox.Text;
            string shareCost = costPerShareTextBox.Text;

            StreamWriter a = new StreamWriter(Application.StartupPath + "\\data\\" + ticker + ".txt");
            a.WriteLine("Ticker - " + tickerNameTextBox.Text);
            a.WriteLine(numShareTextBox.Text + " Shares");
            a.WriteLine("Cost per share - " + "$" + costPerShareTextBox.Text);
            a.Close();
            MessageBox.Show("Added data to " + ticker + ".txt file.");
            this.Close();

        }
    }
}
