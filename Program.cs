using System;

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
              while(i < 1)
              {
                  Console.WriteLine("Digite o nome de seu usuário: ");
                  usuario = Console.ReadLine();
                  Console.WriteLine("Digite a sua senha: ");
                  senha = Console.ReadLine();
                  if(senha != usuario){
                      i++;
                  }else{
                      Console.WriteLine("Senha precisa ser diferente de usuário!");
                  }
              } 

          //Exercicio 3

              Console.WriteLine("Qual a seu nome?");
              string nome = Console.ReadLine();

                if(nome == ""){
                Console.WriteLine("Preencha as informações corretamente!");
              }

              Console.WriteLine("Qual a sua idade?");
              int idade = int.Parse(Console.ReadLine());

              if(idade < 1 || idade > 150 ){
                Console.WriteLine("Há algo de errado!");
              }

              Console.WriteLine("Informe seu salário: ");
              float salario = float.Parse(Console.ReadLine());

              if( salario < 1){
                Console.WriteLine("Informações inseridas incorretamente!");
              }

              Console.WriteLine("Qual seu estado civil? Casado(a) , Solteiro(a) , viuvo(a) , divorciado(a) "); 
              string estadoCivil = Console.ReadLine();
            
              switch(estadoCivil){
                case "Solteiro" :
                  Console.WriteLine("Você é Solteiro!");
                break;

                case "Casado" :
                  Console.WriteLine("Você é Solteiro!");
                break;

                case "Divorciado" :
                  Console.WriteLine("Você é Solteiro!");
                break;

                case "Viuvo" :
                  Console.WriteLine("Você é Solteiro!");
                break;

                default :
                  Console.WriteLine("Preencha as informações corretamente!");
                break;
              }

            //Exercicio Extra

              int x=1, y=0, z=0;
              Console.WriteLine("Digite o número de unidades que a sequencia de Fibonacci deve ter:  (Recomendado até 15)"); 
              int n = int.Parse(Console.ReadLine());

              for (int i = 0; i < n; i++)
              {
                  z = x + y;
                  y = x;
                  x = z;
                  Console.WriteLine(z);
              }
              
        }
    }
}
