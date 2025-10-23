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

namespace ReadingFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string path = @"C:\Student Records\studentlist.txt";
            Directory.CreateDirectory(@"C:\StudentRecords");

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{txtbStudentNo.Text}, {txtbLastName.Text}, {txtbFirstName.Text},{txtbMI.Text},{cbbProgram.Text},{txtbAge.Text},{cbbGender.Text},{dateTimePicker1.Text},{txtbContactNo.Text}");
            }
            MessageBox.Show("Student successfully registered!");
            ClearFields();
        }
        private void ClearFields()
        {
            txtbStudentNo.Clear();
            txtbLastName.Clear();
            txtbFirstName.Clear();
            txtbMI.Clear();
            cbbProgram.SelectedIndex = 0;
            txtbAge.Clear();
            cbbProgram.SelectedIndex = 0;
            txtbContactNo.Clear();

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            FrmStudentRecord record = new FrmStudentRecord();
            record.ShowDialog();
        }
    }
}