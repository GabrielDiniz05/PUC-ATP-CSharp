using System;

class Program{

    static string categoriaNad(int idade){
        if(idade >= 5 && idade <=7){
            return "Categoria: F";
        }else if(idade >= 8 && idade <=10){
            return "Categoria: E";
        }else if(idade >= 11 && idade <= 13){
            return "Categoria: D";
        }else if(idade >= 14 && idade <= 15){
            return "Categoria: C";
        }else if(idade >= 16 && idade <= 17){
            return "Categoria: B";
        }else if(idade >= 18){
            return "Categoria: A";
        }else{
            return "Idade inválida. Sem categoria.";
        }
        return "Erro no sistema!";
    }

    public static void Main(string[] args){
        int idade;
        Console.WriteLine("Insira a idade do nadador para saber a categoria: ");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine(categoriaNad(idade));
    }
}