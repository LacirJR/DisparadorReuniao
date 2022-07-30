using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notificacao
{
    public class Service
    {
        public bool StartProcess(string linkName)
        {
            if (!string.IsNullOrEmpty(linkName) && linkName.Contains("meet.google.com"))
            {
                var path = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", null, null).ToString();
                if (path != null)
                {
                    var split = path.Split('\"');
                    path = split.Length >= 2 ? split[1] : null;
                }
                var process = Process.Start(path, linkName);

                VerificacaoChamadas.Entidade.Processo.ProcessoID = process.Id;
                VerificacaoChamadas.Entidade.Processo.ProcessName = process.ProcessName;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
