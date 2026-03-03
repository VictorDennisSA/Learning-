using System.Configuration;

namespace WinForms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Carregado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("deseja fechar o sistema?");
            MessageBox.Show("Confirma?", " Sistema Victor",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Você clicou em sim");
            }
            else
            { 
                MessageBox.Show("você clicou em não");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = text_nome.Text;
            MessageBox.Show("olá "+ nome ,"seu nome " );
        }
    }
}
