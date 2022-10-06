using System;

class Program{

    public static void Main(String[] args){

        int total_mercadorias = 0;
        double preco_compra = 1, preco_venda, calculo;
        int l_menorDez = 0, l_maior10menor20 = 0, l_maior20 = 0;
        double valor_totalCompra = 0, valor_totalVenda = 0, lucro_total;

        string resposta;

        Console.WriteLine("Bem-Vindo(a)!");
        Console.WriteLine("Insira os valores de preço de compra e venda para calcular o lucro das mercadorias!");

        for (int i = 1; preco_compra > 0; i++){
            total_mercadorias++;

            Console.WriteLine("Insira o preço de COMPRA da {0}º mercadoria: ", i);
            preco_compra = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço de VENDA da {0}º mercadoria: ", i);
            preco_venda = double.Parse(Console.ReadLine());

            valor_totalCompra += preco_compra;
            valor_totalVenda += preco_venda;

            calculo = ((preco_venda * 100) / preco_compra) - 100;

            if (calculo < 10){
                l_menorDez++;
            }else if (calculo >= 10 && calculo <= 20){
                l_maior10menor20++;
            }else{
                l_maior20++;
            }

            Console.WriteLine("Gostaria de adicionar mais uma mercadoria? ");
            resposta = Console.ReadLine();
            if (resposta.ToUpper() == "S"){
                continue;
            }else if (resposta.ToUpper() == "N"){
                preco_compra = 0;
            }else{
                Console.WriteLine("Entrada de dados inválida!");
            }
        }
        lucro_total = ((valor_totalVenda * 100) / valor_totalCompra) - 100;

        Console.WriteLine("Número de mercadorias com lucro menor que 10%: {0} \nMercadorias com lucro menor que 20 e maior que 10: {1} \nMercadorias com lucro maior que 20: {2}", l_menorDez, l_maior10menor20, l_maior20);
        Console.WriteLine("\nValor total de compra: {0 \nValor total de venda: {1} \nLucro Total: {2}", valor_totalCompra, valor_totalVenda, lucro_total);
    }
}