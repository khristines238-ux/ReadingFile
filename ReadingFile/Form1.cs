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
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            var path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvShowText.Items.Add(_getText);
                }
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
            
                try
                {
                    openFileDialog1.InitialDirectory = @"C:\";
                    openFileDialog1.Title = "Browse Text Files";
                    openFileDialog1.DefaultExt = "txt";
                    openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string path = openFileDialog1.FileName;
                        lvShowText.Items.Clear();

                        using (StreamReader reader = new StreamReader(path))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                lvShowText.Items.Add(line);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Open File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

private void FrmOpenTextFile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistration next = new FrmRegistration();
            next.ShowDialog();
            this.Hide();
        }
    }
}
