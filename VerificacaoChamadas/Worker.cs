namespace VerificacaoChamadas
{
    public class Worker : BackgroundService
    {
     
        private readonly VerificarChamada _service;

        public Worker( )
        {
            _service = new VerificarChamada();
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
           
                bool verificarContinuacao = _service.Processar(Entidade.Processo.ProcessoID);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}