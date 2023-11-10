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

namespace Create_Text_File
{
    public partial class FrmLab1 : Form
    {
        public string getInput;

        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmFileName frm = new frmFileName();
            frm.ShowDialog();

            string getInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, frmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration frm = new FrmRegistration();
            frm.ShowDialog();
        }
    }
}
