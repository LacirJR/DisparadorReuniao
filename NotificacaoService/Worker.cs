
using System.Windows.Forms;

namespace NotificacaoService
{
    public class Worker : BackgroundService
    {
        private VerificaTableService _service;

        public Worker()
        {
            _service = new VerificaTableService();

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
               var nomes = _service.VerificaTable();

                if (!string.IsNullOrEmpty(nomes))
                {
                    TelaNotificacao.Entidade.Nomes.Nome = nomes;
                    Application.Run(new TelaNotificacao.TelaNotificacao());
                }

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}