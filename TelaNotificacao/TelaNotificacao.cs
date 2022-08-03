namespace TelaNotificacao
{
    public partial class TelaNotificacao : Form
    {
        public TelaNotificacao()
        {
            InitializeComponent();

        }

        private void TelaNotificacao_Load(object sender, EventArgs e)
        {

            
            txtNotificacao.Text = Entidade.Nomes.Nome.Contains(",") ? Entidade.Nomes.Nome + " estão em reunião!" : Entidade.Nomes.Nome + " está em reunião!";
            txtNotificacao.Dock = DockStyle.Fill; //ou DockStyle.Top; 

            //Vai alinhar o texto sempre no meio
            txtNotificacao.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void txtNotificacao_Click(object sender, EventArgs e)
        {

        }
    }
}