using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio20
{
    interface IVeiculo
    {
        string Descricao { get; set; }
        double CapacidadeMaximaEmKg { get; set; }
        double VelocidadeAtualEmKM { get; }
        double CapacidadeCarregadaemKg { get; }

        double Carregar(double peso);
        double Acelerar();
        double PagarPedagio();



    }
}
