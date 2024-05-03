using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio06
{
    public class Moto : Veiculo
    {
        public int cilindradas;

        public Moto(string marca, string modelo, string cor, int ano, int cilindradas){
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
            this.cilindradas = cilindradas;
        }

    }
}