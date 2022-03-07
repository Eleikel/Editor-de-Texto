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

namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {

        string archivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuItem_Abrir_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Texto |*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;

                using (StreamReader sr = new StreamReader(archivo))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
                Form1.ActiveForm.Text = archivo + " | EleikelNotes";
            }

        }

        private void MenuItem_Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Texto |*.txt";



            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
            else
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = saveFile.FileName;

                    using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }
            }
        }

        private void MenuItem_Nuevo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            archivo = null;
            Form1.ActiveForm.Text = archivo + " | EleikelNotes";

        }

        private void MenuItem_Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            //this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeEleikelNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string message = "App creada por Eleikel";
            string title = "About EleikelNotes";
            MessageBox.Show(message, title);
        }

        private void horaYFechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString();
            richTextBox1.Text = "Fecha y Hora Actual: " + date;
        }

        private void MenuItem_Copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();

        }

        private void MenuItem_Pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }
    }
}
