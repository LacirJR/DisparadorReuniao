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
           
                _service.Processar(Entidade.Processo.ProcessoID);
                Console.WriteLine("ID: " + Entidade.Processo.ProcessoID);
            
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}