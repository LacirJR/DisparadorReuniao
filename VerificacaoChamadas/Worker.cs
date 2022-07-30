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
           
                bool mensagem = _service.Processar(Entidade.Processo.ProcessoID);
                if (mensagem)
                    File.AppendAllText(@"C:\Users\Lacir Junior\Desktop\logTeste.txt", "ID: " + Entidade.Processo.ProcessoID + " Ativo as " + DateTime.Now.ToString("G") + Environment.NewLine);
                else
                {
                    File.AppendAllText(@"C:\Users\Lacir Junior\Desktop\logTeste.txt", "ID: " + Entidade.Processo.ProcessoID + " Inativo as " + DateTime.Now.ToString("G") + Environment.NewLine);
                    return;
                }

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}