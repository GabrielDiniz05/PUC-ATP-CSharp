using System;

class Program{

    public static void Main(String[] args){
        /*
            Faça  um  algoritmo  que  leia  o  ano  de  nascimento  de  uma  pessoa  e  calcule  sua  idade, 
            considerando  o  ano  atual.  Para  verificar  se  já  fez  aniversário  no  ano  atual  pergunte  se  a 
            pessoa  já  fez  aniversário,  sendo  que  ela  pode  entrar  com  a  informação  "S"(sim)  ou  "N" 
            (não).  Com  isto  é  possível  se  ter  maior  precisão  sobre  a  idade.  Verifique  também  se  a 
            pessoa já tem idade para conseguir Carteira de Habilitação (18 anos ou mais) e imprima a 
            mensagem referente a esta checagem. Imprima a idade da pessoa.
        */  

        // Declarando as variáveis ano_nascimento, ano-atual e idade do tipo inteiro. Posteriormente declarando a variavel resposta do tipo string
        int ano_nascimento, ano_atual, idade;
        string resposta;

        // Solicitando a entrada de dados do usuário
        Console.WriteLine("Insira o ano de seu nascimento: ");
        ano_nascimento = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o ano atual: ");
        ano_atual = int.Parse(Console.ReadLine());

        // Solicitando a resposta do usuário
        Console.WriteLine("Já fez aniversário neste ano? Insira 'S' para sim e 'N' para não: ");
        resposta = Console.ReadLine();

        // Verificando a resposta, caso seja SIM a idade é descoberta através da subtração do ano atual com o ano de nascimento
        if(resposta.ToUpper() == "S"){
            idade = ano_atual - ano_nascimento;
            Console.WriteLine("Idade atual: " + idade);
            // Verificando se a idade é menor que 18 anos
            if(idade < 18){
                Console.WriteLine("Você não tem idade suficiente para conseguir a Carteira de Habilitação!");
            }else{
                Console.WriteLine("Você já pode tirar sua Carteira de Habilitação!");
            }
        }
        // Verificando a resposta, caso seja NÃO a idade é descoberta através da subtração do ano atual com o ano de nascimento e posteriormente subtraindo com 1
        else if(resposta.ToUpper() == "N"){
            idade = (ano_atual - ano_nascimento) - 1;
            Console.WriteLine("Idade atual: " + idade);
            // Verificando se a idade é menor que 18 anos
            if(idade < 18){
                Console.WriteLine("Você não tem idade suficiente para conseguir a Carteira de Habilitação!");
            }else{
                Console.WriteLine("Você já pode tirar sua Carteira de Habilitação!");
            }
        }
        // Verificando a resposta, caso não haja nenhuma respota S ou N, a resposta será inválida
        else{
            Console.WriteLine("Entrada de dados inválida!");
        }
    }
}