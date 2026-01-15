using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aldeia.Mercosul.Planilhas.Infra;

namespace Aldeia.Mercosul.Planilhas.App
{
    public class GoogleConnect
    {
        RepositorioGoogle repoGoo = new RepositorioGoogle();

        public GoogleConnect() { }

        public string Connect() => repoGoo.ConnectToGoogle();
    }
}
