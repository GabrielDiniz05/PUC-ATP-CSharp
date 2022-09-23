using System;

class Program{

    public static void Main(String[] args){
        /*
            Leia a velocidade máxima permitida em uma avenida e a velocidade com que o motorista
            estava dirigindo nela. Se o motorista estiver dentro do limite de velocidade, imprima a
            mensagem “Motorista respeitou a lei”. Se o motorista tiver ultrapassado a velocidade
            máxima permitida, calcule e imprima o valor da multa a ser cobrada, sabendo que os
            valores a serem cobrados são os seguintes:
                o 50 reais se o motorista ultrapassar em até 10km/h a velocidade permitida (ex: se a velocidade máxima for 50km/h e o 
                motorista estiver a 60km/h ou a 56km/h);
                o 100 reais, se o motorista ultrapassar de 11 a 30 km/h a velocidade permitida;
                o 200 reais, se estiver acima de 30km/h da velocidade permitida.
        */

        // Declarando as variáveis velocidade máxima, velocidade motorista e multa do tipo double
        double velocidade_max, velocidade_motorista, multa;

        // Solicitando os dados para o usuário
        Console.WriteLine("Insira o valor da velocidade máxima permitida na avenida em KM/H: ");
        velocidade_max = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor da velocidade em que o motorista trafega a avenida em KM/H: ");
        velocidade_motorista = double.Parse(Console.ReadLine());

        // Verificando se o motorista está acima da velocidade permitida ou abaixo
        if(velocidade_motorista > velocidade_max){
            Console.WriteLine("Motorista não respeitou a lei.");
            // Verificalão do valor da multa, caso esteja até 10km/h acima da velocidade máxima permitida, multa de 50 reiass
            if(velocidade_motorista <= (velocidade_max + 10)){
                Console.WriteLine("Multa de: R$50.00");
            }
            // Caso esteja acima de 10km/h acima da velocidade e abaixo de 30km/h da velocidade máxima permitida, multa de 100 reais
            else if(velocidade_motorista > (velocidade_max + 10) && (velocidade_motorista <= (velocidade_max + 30))){
                Console.WriteLine("Multa de: R$100.00");
            }
            // Caso esteja acima de 30km/h da velocidade máxima permitida, multa de 200 reais
            else{
                Console.WriteLine("Multa de: R$200.00");
            }
        }
        // Caso o motorista não esteja acima da velocidade máxima permitida, imprimir que ele respeitou a lei
        else{
            Console.WriteLine("Motorista respeitou a lei.");
        }
    }
}