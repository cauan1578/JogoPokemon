using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JogoPokemon
{
    internal class Program
    {
        int portaPokemon = 0;
        
       

        static void Main(string[] args)

        {

            int tentativas = +1;
            int numTentativas = 20;
            int portaEscolhida = 0;

                Console.WriteLine("Em qual porta você deseja guardar o pokemon ");
                int portaPokemon = int.Parse(Console.ReadLine());

            if (portaPokemon >= 1 && portaPokemon <= 20)
            {
                Console.WriteLine("Porta Ok!");

                Console.Write("");
                while (tentativas <= numTentativas)
                {
                    Console.WriteLine("Advinhe a porta do pokemon");
                    portaEscolhida = int.Parse(Console.ReadLine());


                    if (portaEscolhida == portaPokemon)
                    {
                        Console.WriteLine("Você me achou!");
                        break;

                    }

                    else if (portaEscolhida > portaPokemon)
                    {
                        Console.WriteLine("Estou á esquerda");
                    }
                    else
                    {
                        Console.WriteLine("Estou á direita");

                    }
                    tentativas++;
                    


                }
            }
            else
            {
                Console.WriteLine("A porta está errada. Escolha portas entre 1 e 20.");

            }
            
                Console.ReadKey();
            }


        }
    }