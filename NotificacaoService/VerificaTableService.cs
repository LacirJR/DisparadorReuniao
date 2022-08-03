using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificacaoService
{
    public class VerificaTableService
    {
        private readonly Ef.NOTIFICACAO_RUMOContext _sql;

        public VerificaTableService()
        {
            _sql = new Ef.NOTIFICACAO_RUMOContext();
        }


        public string VerificaTable()
        {

            var usuarios = _sql.Usuarios.Where(x => x.Ativo && !x.Notificacao).Select(x => x).ToList();

            foreach (var usuario in usuarios)
            {
                usuario.Notificacao = true;
                _sql.Usuarios.Update(usuario);
                _sql.SaveChanges();
            }

            if (usuarios.Count == 1)
            {
                return usuarios.First().NomeMaquina;
            }

            string nomesRetorno = "";

            foreach (var usuario in usuarios)
            {
                nomesRetorno += usuario.NomeMaquina + ", ";
            }

            nomesRetorno = nomesRetorno.Length != 0 ? nomesRetorno.Trim().Remove(nomesRetorno.Length - 1) : "";

           
            return nomesRetorno;
        }
    }
}
