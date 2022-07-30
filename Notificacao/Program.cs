using Microsoft.Extensions.Logging;

namespace Notificacao
{
    internal  class Program
    {
        private static ILogger<VerificacaoChamadas.Worker> _logger;

        public  Program(ILogger<VerificacaoChamadas.Worker> logger)
        {
            _logger = logger;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DisparadorNotificacao(_logger));
        }
    }
}