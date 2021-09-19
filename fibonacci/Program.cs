using System;

namespace fibonacci{
    class Program{
        static void Main(string[] args){
            int termo;
            
            Console.Write("Digite o Termo de Fibonacci: ");
            termo = int.Parse(Console.ReadLine())-3;

            DateTime tempoInicioNRec = DateTime.Now;
            Console.WriteLine("A Função Não Recursiva de Fibonacci deu o resultado de {0}", fibonacci(termo));
            DateTime tempoFimNRec = DateTime.Now;
            TimeSpan fimNRec = new TimeSpan(tempoFimNRec.Ticks - tempoInicioNRec.Ticks);
            Console.WriteLine("Em {0} Milisegundos\n\n", fimNRec.Milliseconds);

            DateTime tempoInicioRec = DateTime.Now;
            Console.WriteLine("A Função Recursiva de Fibonacci deu o resultado de {0}", fibonacciRecursivo(termo));
            DateTime tempoFimRec = DateTime.Now;
            TimeSpan fimRec = new TimeSpan(tempoFimRec.Ticks - tempoInicioRec.Ticks);
            Console.WriteLine("Em {0} Milisegundos", fimRec.Milliseconds);

            Console.ReadKey();

        }


        static int fibonacci(int termo){
            int num1=1, num2=1, atual=0;
            for(int i=0; i<termo;i++) {
                atual = num1 + num2;
                num1 = num2;
                num2 = atual;
            }
            return(atual);
        }

        static int fibonacciRecursivo(int termo){
            if(termo > 0) {
                return(fibonacciRecursivo(termo-1)+fibonacciRecursivo(termo-2));
            }
            else {
                return 1;
            }
        }
    }
}
