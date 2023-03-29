using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite a posição desejada na sequência de Fibonacci: ");
        int posicao = int.Parse(Console.ReadLine());

        int resultado = Fibonacci(posicao);

        Console.WriteLine("O número na posição {0} da sequência de Fibonacci é: {1}", posicao, resultado);
    }

    static int Fibonacci(int n) {
        if (n == 0) {
            return 0;
        } else if (n == 1) {
            return 1;
        } else {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}


//O programa solicita ao usuário a posição desejada. Fiz os calculos para as primeiras 3 posições (0,1,1) e em seguida o calculo para as seguintes posições.
//A função fibonacci que é responsável por calcular o número correspondente à posição, que chega na variável resultado.
