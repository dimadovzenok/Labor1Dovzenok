using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor1Dovzenok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);

                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if(SaveDlg.ShowDialog()== DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);

                for(int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Информация о приложение и разработчике");
            Application.Exit();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = textBox1.Text;
            if(checkBox1.Checked)
            {
                foreach( string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);

                }
            }
            if(checkBox2.Checked)
            {
                foreach(string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }

        }
    }
}
