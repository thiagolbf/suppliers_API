using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevIO.Business.Notificacoes;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacao();

        void Handle(Notificacao notificacao);
    }
}
