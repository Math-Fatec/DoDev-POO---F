//Exercicios do Feriado

// POO

//using
using System.ComponentModel;
using Internal;
using System;

    namespace {POO}
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Educação");

            Console.WriteLine("Qual Formação você(usuário) deseja cadastrar:" + Formação());
        }

        public class Formaçao
        {
            public String Descriçao{get;set;}
            public INT Periodo{get;set;}
            public Double Mensalidade{get;set;}
            public INT Duraçao{get;set;}

            DefinirDuraçao();

            ExibirMedia(double);
        }

        protected class DefinirDuraçao
        {
            if (Medio())
            {
                Duraçao = 36;
            } else if (Tecnologo())
            {
                Duraçao = 24;
            } else
            {
                Duraçao =  48;

                if (Descrição = 'Engenharia')
                {
                    Duraçao =  60;
                }
            }
        }

        protected class ExibirMedia (Double double)
        {
            Double provaSemestralUm;
            Double provaSemestralDois;
            Double trabalhoUm;
            Double trabalhoDois;
            Double provaMensalUm;
            Double provaMensalDois;

            Double double;

            trabalhoUm = trabalhoUm * 0,2;
            trabalhoDois = trabalhoDois * 0,2;

            provaMensalUm = provaMensalUm * 0,3;
            provaMensalDois = provaMensalDois * 0,3;

            provaSemestralUm = provaSemestralUm * 0,5;
            provaSemestralDois = provaSemestralDois * 0,5;

            double = trabalhoUm + trabalhoDois + provaMensalUm + provaMensalDois + provaSemestralUm + provaSemestralDois;

            if (double / 6 = double)
            {
                double;
            }

            return double;
        }

        protected class CalcularMensalidade (Double fator)
        {
            Duraçao = Console.ReadLine();

            CargaHorariaEstagio = Console.ReadLine();

            Medio() = (Duraçao * fator * 7);

            Tecnologo() - (Duraçao * fator * 8);

            Bacharelado() - (Duraçao * fator * 8) + (CargaHorariaEstagio * 12);

        }

        public class Tecnologo
        {
            Boolean planoEstendido;

            CalcularMensalidade();
        }

        public class Bacharelado
        {
            String projetoConclusao;
            INT CargaHorarioEstagio;

            CalcularMensalidade();
        }

        public class Medio
        {
            String Tipo;

            CalcularMensalidade();
        }
    }
