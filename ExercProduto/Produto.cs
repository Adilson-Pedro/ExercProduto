using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercProduto
{
    internal class Produto
    {

        // Atributos

        public string Nome;
        public double Preco;
        public int Quantidade;


        // Metodos

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco; 
        }



        public void AdicionarProdutos(int quantidade)
        {

            Quantidade = Quantidade + quantidade;

        }


        public void RemoverProdutos(int quantidade )
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }





       

       


    }
}
