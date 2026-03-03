namespace WinFormsApp125._02._26
{
    public partial class Form1 : Form
    {
        List<string> nomes = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            object OnEnter;
            string nome = txt_name.Text;
            if (!string.IsNullOrEmpty(nome))
            {
            
               nomes.Add(nome);
                list_name.Items.Add(nome);
                txt_name.Clear();
                txt_name.Focus();
            }
        }

        private void list_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (list_name.SelectedItems != null)
            {
                string NameSelec = list_name.SelectedItem.ToString();
                nomes.Remove(NameSelec);
                list_name.Items.Remove(NameSelec);
            }
        }
    }
}
