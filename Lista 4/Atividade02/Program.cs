using System;

class Program{

    static void CalculaMedia(double[] notas){
        double totalNotas = 0;
        double media = 0;
        int alunosAciMed = 0;
        for(int i = 0; i < notas.Length; i++){
            totalNotas+=notas[i];    
        }
        media = totalNotas / notas.Length;

        for(int i = 0; i < notas.Length; i++){
            if(notas[i] > 6){
                alunosAciMed++;
            }
        }

        Console.WriteLine("A média de notas dos alunos é: {0} " + 
        "\nO total de alunos acima da média é: {1}", media, alunosAciMed);
    }

    static double[] NotasFunc(int qntN){
        double[] notas = new double[qntN];
        for(int i = 0; i < qntN; i++){
            Console.WriteLine("Insira a " + (i+1) + "º nota: ");
            notas[i] = double.Parse(Console.ReadLine());
        }
        return notas;
    }

    public static void Main(string[] args){
        int qntNotas = 0;

        Console.WriteLine("Insira a quantidade de notas que deseja calcular: ");
        qntNotas = int.Parse(Console.ReadLine());

        double[] notas = NotasFunc(qntNotas);
        
        CalculaMedia(notas);

       

    }
}