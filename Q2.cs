using System;

namespace questao2 {
    class Program {
        static void Main(string[] args) {

            int contaElementosMatriz(int[][] matriz, int l, int c) {
                int result = 0;
                int contPar = 0, conttImp = 0;

                for (int i = 0; i < l; i++) {
                    for (int j = 0; j < c; j++) {
                        if (matriz[i][j] % 2 == 0)
                            contPar++;
                        else conttImp++;
                    }
                }

                if (contPar > conttImp)
                    result = contPar;
                else
                    result = conttImp;

                return result;
            }

        }
    }
}
