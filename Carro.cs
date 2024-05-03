using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio06
{
    public class Carro : Veiculo
    {
        public int qtdePortas;

        public Carro(string marca, string modelo, string cor, int ano, int qtdePortas){
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
            this.qtdePortas = qtdePortas;
        }

    }
}