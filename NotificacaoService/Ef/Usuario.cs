using System;
using System.Collections.Generic;

namespace NotificacaoService.Ef
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string NomeMaquina { get; set; } = null!;
        public bool Ativo { get; set; }
        public bool Notificacao { get; set; }
        public DateTime HorarioAtivo { get; set; }
    }
}
