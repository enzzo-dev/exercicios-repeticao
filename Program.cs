﻿using System;

namespace exercicios_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
          //Exercicio 1

              int contador = 0;
              float nota;

              while(contador < 1)
              {
                Console.WriteLine("Digite uma nota de 0 a 10: ");
                nota = int.Parse(Console.ReadLine());
                if(nota < 1 || nota > 10){
                  Console.WriteLine("Digite uma nota válida!");
                } else{
                  contador++;
                }
              }
                
          //Exercicio 2 

              int i = 0;
              string senha , usuario;
              Console.WriteLine("Digite o nome de seu usuário: ");
              usuario = Console.ReadLine();
              Console.WriteLine("Digite a sua senha: ");
              senha = Console.ReadLine();
              while(i < 1)
              {
                  if(senha != usuario){
                      i++;
                  }else{
                      Console.WriteLine("Digite a sua senha: ");
                      senha = Console.ReadLine();
                  }
              } 
               Console.WriteLine($"Usuário {usuario} cadastrado com sucesso!");

          //Exercicio 3

              Console.WriteLine("Qual o seu nome?");
              string nome = Console.ReadLine();
              while(nome == "")
              {
                Console.WriteLine("Seu nome não pode estar vazio!");
                Console.WriteLine("Qual a seu nome?");
                nome = Console.ReadLine();
              }

              Console.WriteLine("Qual a sua idade?");
              int idade = int.Parse(Console.ReadLine());

              while(idade < 1 || idade > 90 ){
                Console.WriteLine("Há algo de errado! Digite novamente: ");
                System.Console.WriteLine("----------------------------");
                Console.WriteLine("Qual a sua idade?");
                idade = int.Parse(Console.ReadLine());
              }

              Console.WriteLine("Informe seu salário: ");
              float salario = float.Parse(Console.ReadLine());

              while( salario < 1){
                Console.WriteLine("Informações inseridas incorretamente! Digite novamente: ");
                System.Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Informe seu salário: ");
                salario = float.Parse(Console.ReadLine());
              }

              Console.WriteLine("Qual seu estado civil?  C - Casado(a) , S - Solteiro(a) , V - viuvo(a) , D - divorciado(a) "); 
              string estadoCivil = Console.ReadLine();

              while(estadoCivil.ToLower() != "c" && estadoCivil.ToLower() != "s" && estadoCivil.ToLower() != "v" && estadoCivil.ToLower() != "d")
              {
                  Console.WriteLine("Voce digitou incorretamente! Digite novamente dentro das opções disponiveis!");
                  System.Console.WriteLine("-----------------------------------------------------------------------------");
                  Console.WriteLine("Qual seu estado civil? C - Casado(a) , S - Solteiro(a) , V - viuvo(a) , D - divorciado(a) "); 
                  estadoCivil = Console.ReadLine(); 
              }

            //Exercicio Extra

              int numAtual=1, numAnt=0, prox=0;
              int n = 17;
              for (int i3 = 0; i3 < n; i3++)
              {
                  prox = numAtual + numAnt;
                  numAnt = numAtual;
                  numAtual = prox;
                  Console.WriteLine(prox);
              }
              // Console.WriteLine($" A sequencia de Fibonacci vai se repetir {n} vezes até chegar ao valor de {prox} ultrapassando 500 como se pede o exercicio!"); 
              
        }
    }
}
