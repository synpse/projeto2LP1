﻿using System;


namespace Projeto2_LP1
{
    class Renderer
    {
     // private readonly int Width;
      //private readonly int Height;

      /*public Renderer(int width, int height)
        {
          this.Width = width;
          this.Height = height;
        }*/

          

        public static void Render(Grid grid)
        {
            State[,] array = new State[8, 8];

            foreach(State s in array)
            {

            }

            int linhafinal = array.GetLength(0);
            int colinafinal = array.GetLength(1);

            for (int linha = 0; linha < 8; linha++)
                for (int coluna = 0; coluna < 8; coluna++)
                  //  array[linha,coluna] = 
                    Console.WriteLine($"{array[linha,0]}");


            /*Malta esta parte esta correcta. mas tou com duvidas agora na parte seguinte:


                  tipo o nosso array nao tem nada la dentro foi so construido 8 por 8, logo ao correr o programa vais vos aparecer "undecided" porque nao tem nada

                  o que se pretende e que dentro de cada "casa" do array introduzamos "-" que neste caso na class state e a nossa explored, mas como nesta fase nao e preciso

                  implementar o explorado e nao explorado tentem arranjar maneira de introduzir o - de outra maneira

                  note: pff nao introduzam desta forma  int[,] values=new int[2,3]{{2,4,5},{4,5,2}};  
                  isto nao nos vais ajudar em nada porque mais tarde vms voltar ao mesmo
                  
             thanks in advance*/




        }
    }
}
