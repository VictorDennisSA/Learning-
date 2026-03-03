namespace formExercício13._02._26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (text_nome.Text.Any())
            {
                string nome1 = text_nome.Text;
                MessageBox.Show($"Bem vindo {nome1}!", "Saudações");
            }
            else
            {
                string nome1 = text_nome.Text;
                MessageBox.Show($"Insira um nome!", "ERROR");
            }





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_ecivil.Items.Add("Selecione uma opção");
            list_ecivil.Items.Add("Solteiro");
            list_ecivil.Items.Add("Casado");
            list_ecivil.Items.Add("Viúvo");
            list_ecivil.Items.Add("Divorciado");

            list_ecivil.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
