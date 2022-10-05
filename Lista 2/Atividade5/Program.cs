using System;

class Program{

    public static void Main(String[] args){

        double salario = 1, salario_total = 0, numero_filhos, filhos_total = 0;
        double media_salario, media_filhos, maior_salario = 0, salario_menor100 = 0, percentual;
        int numero_habitantes = 0;

        string resposta;

        Console.WriteLine("Olá! Bem-Vindo(a)!");
        Console.WriteLine("Deseja iniciar a pesquisa? (s/n)");
        resposta = Console.ReadLine();
        
        if(resposta.ToUpper() == "S"){
            while(salario > 0){
                numero_habitantes++;

                Console.WriteLine("Insira o seu salário bruto: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade de filhos: ");
                numero_filhos = double.Parse(Console.ReadLine());

                if(salario < 100.0)
                    salario_menor100++;
                
                if(salario > maior_salario)
                    maior_salario = salario;
                
                salario_total+=salario;
                filhos_total+=numero_filhos;

                Console.WriteLine("Deseja continuar a pesquisa? (s/n)");
                resposta = Console.ReadLine();
                if(resposta.ToUpper()  == "S"){
                    continue;
                }else if(resposta.ToUpper() == "N"){
                    salario = -1;
                }else{
                    Console.WriteLine("Entrada de dados inválida! Finalizando pesquisa.");
                    salario = -1;
                }
            }

            media_salario = salario_total / numero_habitantes;
            media_filhos = filhos_total / numero_habitantes;

            percentual = (salario_menor100*100) / numero_habitantes;

            Console.WriteLine("\n\nA média de salário da população é: R${0:N2} " + 
                            "\nA média de filhos é: {1:N1} " + 
                            "\nO maior salário é: {2} " + 
                            "\nO percentual de pessoas com salário até R$100,00 é: {3:N0}%", media_salario, media_filhos, maior_salario, percentual);
            Console.WriteLine("\n\nObrigado pelas informações! Volte sempre!");
        }else if(resposta.ToUpper() == "N"){
            Console.WriteLine("Volte sempre!");
        }else{
            Console.WriteLine("Entrada de dados inválida!");
        }
    }
}