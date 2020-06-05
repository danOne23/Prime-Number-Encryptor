using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string o;
            try
            {
                o = Program.Encrypt(inputTxt.Text, inputKey.Text, inputSepearator.Text);
            } catch (System.FormatException)
            {
                o = "error";
            }

            outputTxt.Text = o;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string o;
            try
            {
                o = Program.Decrypt(inputTxt.Text, inputKey.Text, inputSepearator.Text);
            }
            catch (System.FormatException)
            {
                o = "error";
            }

            outputTxt.Text = o;
        }
    }
}
