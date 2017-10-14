using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // Classe no modelo Singleton simples
    public sealed class Servidor
    {
        private static readonly Servidor instance = new Servidor();
        public string IP { get; set; }
        public string USUARO { get; set; }
        public string SENHA { get; set; }

        private Servidor() { }

        public static Servidor Instance
        {
            get
            {
                return instance;
            }
        }
    }

    
}


