using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Estrurura.Model
{
    public class Funcionario : Pessoa //             não preciso me preocupar com tudo que já tem em pessoa (herança)
    {
        public int cdMatricula {  get; set; }

        public string cargo { get; set; }
    }
}
