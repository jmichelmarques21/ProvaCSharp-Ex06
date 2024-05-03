using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio06
{
    public class Bicicleta : Veiculo
    {
        public int marchas;

        public Bicicleta (string marca, string modelo, string cor, int ano, int marchas) {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
            this.marchas = marchas;
        }


    }
}