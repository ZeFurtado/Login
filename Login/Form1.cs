namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkedListBox1.Items.Add("M (Masculino)");
            checkedListBox1.Items.Add("F (Feminino)");
            checkedListBox1.Items.Add("O (Outro)");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}