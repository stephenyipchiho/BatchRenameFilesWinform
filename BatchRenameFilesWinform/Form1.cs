using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BatchRenameFilesWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.textBox1.Text.Trim()))
            {
                foreach (string fp in Directory.GetFiles(this.textBox1.Text.Trim()))
                {
                    File.Move(fp, fp.Replace(this.textBox2.Text.Trim(), ""));

                }
                MessageBox.Show("done.");
            }
            else
            {

                MessageBox.Show("folder not exist");
            }
        }
    }
}
