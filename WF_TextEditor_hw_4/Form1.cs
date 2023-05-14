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

namespace WF_TextEditor_hw_4
{
    public partial class Form1 : Form
    {
        string docname, tmpTxt;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*| Text Files(*.txt)|*.txt||";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                richTextBox1.Text = reader.ReadToEnd();
                tmpTxt = richTextBox1.Text;
                reader.Close();
            }
            docname = open.FileName;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt)|*.txt||";
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionLength>0)
            {
                richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (Clipboard.ContainsText())
            {
                richTextBox1.Paste();
            }//Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (docname!=null)
            {
                save.FileName = docname;
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }

        private void delToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText = "";
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = richTextBox1.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void fColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void bColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpTxt != richTextBox1.Text)
            {
                DialogResult res = MessageBox.Show("Сохранить изменения?", "Изменения не сохранены", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (docname != null)
                    {
                        сохранитьToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        сохранитьКакToolStripMenuItem_Click( sender,  e);
                    }
                }
            }
        }
    }
}
