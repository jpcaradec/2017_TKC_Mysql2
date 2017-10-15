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
    class Tabelas
    {
        class Info
        {
            //Campos
            int id;
            int lt;             //Número do Live Timing
            string data;        //DD/MM/AA
            string hora;        //HH:MM:SS
            string campeonato;
            string grupo;
            string evento;
            string tipo;        //P Q R
            string duracao;     //Total de Tempo ou Total de Voltas
            string ttime;       // cronmetro
            string paraofim;    //Tempo ou Volyas para o fim
            string mlvtanum;    //Numero do carro da melhor volta
            string mlvtanome;   //Nome do(s) pilotos da melhor volta
            string mlvtatempo;  //Tempo da melhor volta
            string mlvtana;     //Numero da volta da melhor volta
            string opcional;    //Texto com outras informações
        }
        class Resu
        {
            //Campos
            int id;
            int lt;
            int pos;            //Número da Posição
            string num;         //Numero do carro
            string cat;         //Categoria PS: Qdo tiver mais de uma categoria separar com barra |
            string NomeTV;      //Nome do(s) Pilotos para a TV
            string Nomes;       //Nome do(s) Pilotos separados por barra
            string IDPilotos;   //ID(s) do(s) Pilotos separados por barra

            int TotaldeVts;     //Total de Voltas

            string TTime;       //TTime
            string TTimeAnt;    //TTime anterior;
            string TTOpcional;  //TTime Opcional

            string mlVtaTempo;  //Tempo da Melhor Volta
            string mlVtaNa;     //Num da Melhor Volta
            string mlVtaPlt;    //Plt da Melhor Volta
            string mlvtaMedia;  //Media Melhor Vta (Km/h)


            string TimeLine;    //Timeline;
            string TimeLineAnt; //Timeline Ocional;

            string Stint;       //Stint
            string StintOpcinal;//Stint Opcional

            int Pits;
            int PitsOpcional;
            string PitTime;
           
        }
    }
}
