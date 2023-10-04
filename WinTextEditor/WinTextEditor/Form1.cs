using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTextEditor
{
    public partial class FormMain : Form
    {
        string FileName {  get; set; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                buttonSave.Enabled = true;
                // MessageBox.Show(filename);
                string txt = File.ReadAllText(FileName);
                txtOutput.Text = txt;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FileName, txtOutput.Text);
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileNameToSave = saveFileDialog.FileName;
                File.WriteAllText (fileNameToSave, txtOutput.Text);
            }
                

        }
    }
}
