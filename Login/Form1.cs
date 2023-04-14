namespace Login
{
    public partial class Form1 : Form
    {

        MySqlOperations mySqlOperations = new MySqlOperations();
        public Form1()
        {
            InitializeComponent();

            cmboxSexo.Items.Add("Masculino");
            cmboxSexo.Items.Add("Feminino");
            cmboxSexo.Items.Add("Outro");

            txtSenha.PasswordChar = '*';
            txtRepSenha.PasswordChar = '*';


            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O campo 'Nome' está vazio");
            }
            else if (string.IsNullOrEmpty(txtSobrenome.Text))
            {
                MessageBox.Show("O campo 'Sobrenome' está vazio");
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O campo 'Senha' está vazio");
            }
            else if (string.IsNullOrEmpty(txtRepSenha.Text))
            {
                MessageBox.Show("Você precisa digitar a senha novamente");
            } else if (SenhaValida(txtSenha.Text, txtRepSenha.Text))
            {
                string nome_usuario = CriaNomeUsuario(txtNome.Text, txtSobrenome.Text);
                string senha = txtSenha.Text;

                mySqlOperations.Insert("user_data", txtNome.Text, txtSobrenome.Text, nome_usuario, cmboxSexo.Text, senha);
                LimpaCampos();
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void LimpaCampos() 
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtSenha.Clear();
        }

        bool ValidaNome(string nome) 
        {
            if (string.IsNullOrEmpty(nome)) 
            {
                MessageBox.Show("Digita o nome certo");
                return false;
            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mySqlOperations.Select(txtSenhaLogin.Text, "test");
        }


        private string CriaNomeUsuario(string nome, string sobrenome)
        {
            string nome_usuario;

            nome_usuario = nome.ToLower() +"."+sobrenome.ToLower();
            return nome_usuario;
        }

        private bool SenhaValida(string senha, string repSenha) 
        {
            if (senha == repSenha)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        
    }
}