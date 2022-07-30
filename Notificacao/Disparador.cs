using Microsoft.Extensions.Logging;

namespace Notificacao
{
    public partial class DisparadorNotificacao : Form
    {
        private readonly ILogger<VerificacaoChamadas.Worker> _logger;

        public DisparadorNotificacao(ILogger<VerificacaoChamadas.Worker> logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnIrParaLink_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            var processo = new Service().StartProcess(txtIncluirLink.Text);
            var cancelToken = new CancellationTokenSource();
            if (processo == false)
                lblErro.Visible = true;
            else
                await new VerificacaoChamadas.Worker().StartAsync(cancelToken.Token);



        }

        private void txtIncluirLink_TextChanged(object sender, EventArgs e)
        {

        }
    }
}