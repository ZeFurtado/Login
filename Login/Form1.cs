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
            } else if (SenhaValida(txtSenha.Text, txtRepSenha.Text) && NomeValido(txtNome.Text, txtSobrenome.Text))
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
            txtRepSenha.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mySqlOperations.Select(txtSenhaLogin.Text, "test");
        }


        private string CriaNomeUsuario(string nome, string sobrenome)
        {
            string nome_usuario;

            nome_usuario = nome.ToLower()+"."+sobrenome.ToLower();
            return nome_usuario;
        }



        private bool NomeValido(string nome, string sobrenome) 
        {

            foreach (char a in nome) 
            {
                if (char.IsDigit(a)) 
                {
                    MessageBox.Show("O nome é inválido!!!");
                    return false;
                    break;
                }
            }

            foreach (char a in sobrenome) 
            {
                if (char.IsDigit(a)) 
                {
                    MessageBox.Show("O sobrenome é inválido!!!");
                    return false;
                    break;
                }
            }

            return true;
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