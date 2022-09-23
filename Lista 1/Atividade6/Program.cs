using System;

public class Program{

    public static void Main(String[] args){
        /*
            Um  hotel  com  75  apartamentos  deseja  fazer  uma  promoção  especial  de  final  de  semana, 
            concedendo  um  desconto  de  25%  na  diária.  Com  isto,  espera  aumentar  sua  taxa  de 
            ocupação  de  50  para  80%.  Sendo  dado  o  valor  normal  da  diária,  calcular  e  imprimir:  
            
            a) o valor da diária promocional;  
            b) o valor total arrecadado com 80% de ocupação e diária promocional;  
            c) o valor total arrecadado com 50% de ocupação e diária normal;  
            d) a diferença entre estes dois valores. 
        */

        // Declaração das variáveis do tipo Double
        double valor_diaria, valor_promo, diaria_promo, val_total_80, val_total_50, diff, desconto, num_apt;

        // Solicitando a entrada de dados do usuário
        Console.WriteLine("Insira o valor da diária normal: ");
        valor_diaria = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o número de apartamentos: ");
        num_apt = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor da promoção: ");
        valor_promo = double.Parse(Console.ReadLine());
        
        // Armazenando o valor da promoção na variável desconto para ser imprimido mais tarde
        desconto = valor_promo;

        // Calculando o valor da diária com promoção, dividindo o valor da promoção por 100 e posteriormente multiplicando com o valor da diária
        // para descobrir o valor exato da promoção e posteriormente subtraindo o valor da diária pelo valor em reais da promoção
        diaria_promo = valor_diaria - ((valor_promo/=100) * valor_diaria);

        // Calculando o valor total arrecadado pela diária na promoção com 80% de ocupação
        val_total_80 = (75.0 * 0.8) * diaria_promo;

        // Calculando o valor total arrecadado pela diária normal com 50% de ocupação
        val_total_50 = (75.0 * 0.5) * valor_diaria;

        // Imprimindo os valores solicitados no exercício
        Console.WriteLine("O valor da diária normal é: R$" + valor_diaria);
        Console.WriteLine("O valor do desconto é de: " + desconto + "%");
        Console.WriteLine("O valor da diária com promoção é: R$" + diaria_promo);
        Console.WriteLine("O valor total arrecadado com a diária na promoção mais 80% de ocupação é: R$" + val_total_80);
        Console.WriteLine("o valor total arrecadado com a diária normal mais 50% de ocupação é: R$" + val_total_50);
        // Fazendo uma verificação para descobrir qual o maior valor e qual foi a diferença entre os preços das diárias
        if(val_total_80 > val_total_50){
            diff = val_total_80 - val_total_50;
            Console.WriteLine("A difirença de valores totais arrecadados é: R${0}, sendo o valor com promoção o maior.", diff);
        }else if(val_total_50 > val_total_80){
            diff = val_total_50 - val_total_80;
            Console.WriteLine("A difirença de valores totais arrecadados é: R${0}, sendo o valor normal o maior", diff);
        }else{
            Console.WriteLine("Não há diferença entre os valores totais arrecadados.");
        }
    }
}