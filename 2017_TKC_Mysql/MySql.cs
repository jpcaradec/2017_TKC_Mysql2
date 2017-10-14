using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
    class BancodeDados
    {
        class Servidor
        {
            private string IP;
            private string Usuario;
            private string Senha;
        }
        
        //Verifica acesso ao Servidor
        private bool VerificaBD(string ip, string usuario, string senha)
        {
            return true;
        }

        //Verifica se Servidor tem o Banco de Dados (bd)
        private bool VerificaBD(string ip, string usuario, string senha, string bd)
        {

            return true;
        }

        //Cria bd no Servidor
        private bool CriaBd(Servidor servidor)
        {
            return true;
        }
    }
}
