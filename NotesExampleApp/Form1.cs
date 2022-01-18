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

namespace NotesExampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            StreamReader streamReader = null;
            openFileDialog.Filter = "Archivos de texto (.txt)|*.txt";
            openFileDialog.Title = "Abrir archivo";
            openFileDialog.ShowDialog();
            openFileDialog.OpenFile();
            string route = openFileDialog.FileName;
            streamReader = File.OpenText(route);
            richTextBox1.Text = streamReader.ReadToEnd();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            StreamWriter streamWriter = null;
            saveFileDialog.Filter = "Archivos de texto (.txt)|*.txt";
            saveFileDialog.Title = "Guardar como...";
            saveFileDialog.ShowDialog();
            string route = saveFileDialog.FileName;
            streamWriter = File.AppendText(route);
            streamWriter.Write(richTextBox1.Text);
            streamWriter.Flush();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
