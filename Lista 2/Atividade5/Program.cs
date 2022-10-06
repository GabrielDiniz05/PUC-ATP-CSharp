using System;

class Program{

    public static void Main(String[] args){

        /*
            5. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o
            salário e número de filhos de cada habitante. A prefeitura deseja saber:
            a) média do salário da população;
            b) média do número de filhos;
            c) maior salário;
            d) percentual de pessoas com salário até R$100,00.
            O final da leitura de dados se dará com a entrada de um salário negativo
        */

        // Declarando as variáveis
        double salario = 1, salario_total = 0, numero_filhos, filhos_total = 0;
        double media_salario, media_filhos, maior_salario = 0, salario_menor100 = 0, percentual;
        int numero_habitantes = 0;

        string resposta;

        // Solicitando uma entrada de dados para iniciar o programa
        Console.WriteLine("Olá! Bem-Vindo(a)!");
        Console.WriteLine("Deseja iniciar a pesquisa? (s/n)");
        resposta = Console.ReadLine();
        
        if(resposta.ToUpper() == "S"){
            // Laço de repetição para manter o programa rodando enquanto salario for maior que 0
            while(salario > 0){
                // Quando se entra na pesquisa o número de habitantes aumenta
                numero_habitantes++;

                // Solicitando a entrada de dados
                Console.WriteLine("Insira o seu salário bruto: ");
                salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira a quantidade de filhos: ");
                numero_filhos = double.Parse(Console.ReadLine());

                // Estrutura condicional para verificar quantos habitantes tem salario menor que 100
                if(salario < 100.0)
                    salario_menor100++;
                
                // Estrutura condicional para verificar qual é o maior salário entre os habitantes
                if(salario > maior_salario)
                    maior_salario = salario;
                
                // Soma e atribuição de valores para descobrir a quantidade total de salario e de filhos
                salario_total+=salario;
                filhos_total+=numero_filhos;

                // Solicitando e verificando se o usuário deseja continuar na pesquisa
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
            
            // Realizando uma operação de média aritmética para verificar a média de salario e de filhos
            media_salario = salario_total / numero_habitantes;
            media_filhos = filhos_total / numero_habitantes;

            // Realizando uma operação para verificar o percentual de habitantes com salário menor que 100
            percentual = (salario_menor100*100) / numero_habitantes;

            // Imprimindo o resultado
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