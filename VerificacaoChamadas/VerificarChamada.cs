using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DotLiquid;

namespace VerificacaoChamadas
{
    public class VerificarChamada
    {

        #region Construtor
        public readonly Ef.NOTIFICACAO_RUMOContext _sql;

        public VerificarChamada()
        {
            _sql = new Ef.NOTIFICACAO_RUMOContext();
        }

        #endregion

        #region BuscarUsuario
        public Ef.Usuario BuscarUsuario()
        {
            var nomeUsuario = Environment.UserName;
            var usuario = new Ef.Usuario();
            var retornoPesquisa = _sql.Usuarios.Where(x => x.NomeMaquina == nomeUsuario).FirstOrDefault();
            if (retornoPesquisa == null)
            {
                usuario = new Ef.Usuario()
                {
                    NomeMaquina = nomeUsuario,
                    HorarioAtivo = DateTime.Now,
                    Ativo = false,
                    Notificacao = false
                };
                _sql.Usuarios.Add(usuario);

                _sql.SaveChanges();
            }
            else
            {
                usuario = retornoPesquisa;
            }

            return usuario;
        }
        #endregion

        #region AtivarStatusNaTabela
        public Ef.Usuario AtivarStatusNaTabela(Ef.Usuario usuario)
        {
            if (!usuario.Ativo)
            {
                usuario.Ativo = true;
                usuario.HorarioAtivo = DateTime.Now;
                usuario.Notificacao = true;
                _sql.Usuarios.Update(usuario);
                _sql.SaveChanges();
            }
            return usuario;
        }

        #endregion

        #region DesativarStatusNaTabela
        public Ef.Usuario DesativarStatusNaTabela(Ef.Usuario usuario)
        {
            if (usuario.Ativo)
            {
                usuario.Ativo = false;
                usuario.HorarioAtivo = DateTime.Now;
                usuario.Notificacao = false;
                _sql.Usuarios.Update(usuario);
                _sql.SaveChanges();
            }
            return usuario;
        }
        #endregion


        public bool Processar(int idProcesso)
        {
            var usuario = BuscarUsuario();
            try
            {

                if (idProcesso == 0)
                    return false;

                var processoExecucao = Process.GetProcessById(idProcesso);

                

                if (processoExecucao.Responding)
                    AtivarStatusNaTabela(usuario);

                return true;

            }
            catch (Exception ex)
            {
                DesativarStatusNaTabela(usuario);
                return false;
            }











        }



    }


}
