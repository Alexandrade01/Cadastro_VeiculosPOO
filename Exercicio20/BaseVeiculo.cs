using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    abstract class BaseVeiculo : IVeiculo
    {
        protected string descricao;
        protected double capacidadeMaximaEmKm;
        protected double velocidadeAtualEmKM;
        protected double capacidadeCarregadaemKg;

        public BaseVeiculo(string descricao, double capacidadeMaximaEmKg)
        {
            this.Descricao = descricao;
            this.CapacidadeMaximaEmKg = capacidadeMaximaEmKg;
            velocidadeAtualEmKM = 0;
            capacidadeCarregadaemKg = 0;
        }
        public string Descricao
        {
            get => descricao;
            set => this.descricao = Validacao.ValidaNomes(value);
        }
        public double CapacidadeMaximaEmKg
        {
            get => this.capacidadeMaximaEmKm;
            set => this.capacidadeMaximaEmKm = Validacao.ValidaDadosdouble(value);
        }

        public double VelocidadeAtualEmKM => velocidadeAtualEmKM;

        public double CapacidadeCarregadaemKg => capacidadeCarregadaemKg;



        public virtual double Acelerar()
        {
            velocidadeAtualEmKM++;
            return VelocidadeAtualEmKM;
        }

        public abstract double Carregar(double peso);
        public abstract double PagarPedagio();
        public override string ToString()
        {
            return "Descrição :"
                + Descricao
                + Environment.NewLine
                + " Capacidade Maxima em Kg "
                + CapacidadeMaximaEmKg
                + Environment.NewLine
                + " Velocidade atual em KM "
                + VelocidadeAtualEmKM
                + Environment.NewLine
                + " Capacidade Carregada em Kg "
                + CapacidadeCarregadaemKg
            + Environment.NewLine;
        }

      
    }
}




