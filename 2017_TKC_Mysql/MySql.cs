using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace MySql
{
    class BancodeDados
    {
        
        
        //Verifica acesso ao Servidor (Manespace Singleton)
        private bool VerificaBD(Servidor servidor)
        {
            return true;
        }

        //Verifica se Servidor tem o Banco de Dados (Manespace Singleton Servidor + bd)
        private bool VerificaBD(Servidor servidor, string bd)
        {

            return true;
        }

        //Cria bd no Servidor
        private bool CriaBd(Servidor servidor, string bd)
        {
            return true;
        }
    }
}
