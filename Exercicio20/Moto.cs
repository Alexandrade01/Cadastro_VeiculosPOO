using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    class Moto : BaseVeiculo
    {
        private int cilindradas;
        public int Cilindradas { get => cilindradas; set => this.cilindradas = Validacao.Validainteiros(value); }

        public Moto(string descricao, double capacidadeMaximaEmKg, int cilindradas) : base(descricao, capacidadeMaximaEmKg)
        {
            Cilindradas = cilindradas;
        }
        public override double Carregar(double peso)
        {

            if (CapacidadeCarregadaemKg + peso > CapacidadeMaximaEmKg)
            {
                throw new Exception("Moto sobrecarregada!");
            }
            else
            {
                capacidadeCarregadaemKg += peso;
                return CapacidadeCarregadaemKg;
            }
        }

        public override double PagarPedagio()
        {
            return 2;
        }
        public string Empinar()
        {
            return "Empinando...";
        }
        public override string ToString()
        {
            return base.ToString() + "Cilindradas :" + Cilindradas;
        }

        

    }
}
