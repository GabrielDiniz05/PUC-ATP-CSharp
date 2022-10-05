using System;

class Program{

    public static void Main(String[] args){

        int total_mercadorias;
        double preco_compra, preco_venda;

        Console.WriteLine("Bem-Vindo(a)!");
        Console.WriteLine("Insira os valores de preço de compra e venda para calcular o lucro das mercadorias!");

        for(int i = 1; preco_compra > 0; i++){
            total_mercadorias++;
            
            Console.WriteLine("Insira o preço de COMPRA da {0}º mercadoria: ", i);
            preco_compra = double.parse(Console.ReadLine());
            Console.WriteLine("Insira o preço de VENDA da {0}º mercadoria: ", i);
            preco_venda = double.Parse(Console.ReadLine());

            
        }
        

    }
}