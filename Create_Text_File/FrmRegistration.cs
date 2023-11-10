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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text;
            string getFirstName = txtFirstName.Text;
            string getMiddleName = txtMiddleInitial.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getBirthday = datePickerBirtday.Value.ToString("yyyy-MM-dd");
            string getProgram = cbPrograms.Text;
            string getGender = cbGender.Text;
            string getContact = txtContactNo.Text;
            string setFileName = String.Concat(getStudentNo, ".txt");

            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath2, setFileName));

            string[] info = {"Student No: " + getStudentNo,
                             "FullName: " + getLastName + ", " + getFirstName + ", " + getMiddleName, 
                             "Program: " + getProgram,
                             "Gender: " + getGender,
                             "Age: " + getAge, 
                             "Birthday: " + getBirthday, 
                             "Contact No: " + getContact};
            
            
            Console.WriteLine(getStudentNo);
            foreach (string i in info)
            {
                outputFile.WriteLine(i);
            }
            outputFile.Close();
            MessageBox.Show("Successfully saved!!!");
            Close();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[] { "BS Information Technology",
                                                    "BS Computer Science",
                                                    "BS Information Systems",
                                                    "BS in Accountancy",
                                                    "BS in Hospitality Management",
                                                    "BS in Tourism Management" };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            string[] listGender = new string[] { "Male", "Female" };

            for (int i = 0; i < 2; i++)
            {
                cbGender.Items.Add(listGender[i].ToString());
            }
        }
    }
}
