using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TesteAgapys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            txtArquivo.Text = Path.GetFullPath(
               Path.Combine(Application.StartupPath, "..\\..\\new 1.txt"));
        }

        private void BtnArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Multiselect = false;
            ofd1.Title = "Selecionar Arquivo";
            ofd1.InitialDirectory = @"C:\dados\txt\";
            ofd1.Filter = "Images (*.TXT)|*.TXT|" + "Todos (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 1;

            DialogResult dr = ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                txtArquivo.Text = ofd1.FileName;
            }
        }

        private void BtnLocalizar_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();
            lblResultados.Text = "";
            Refresh();

            string criterio = txtCriterio.Text;

            string[] linhas = File.ReadAllLines(txtArquivo.Text);

            foreach (string linha in linhas)
            {
                if (linha.Contains(criterio))
                    lbResultado.Items.Add(linha);
            }

            lblResultados.Text = lbResultado.Items.Count.ToString() + " ocorrências";
        }

        private void BtnEncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar ?", "Encerrar", MessageBoxButtons.YesNo)
                 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}