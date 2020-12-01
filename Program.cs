using System;

namespace Atributos_e_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem = new Personagem();

            objetoPersonagem.nome = "Tsukamoto";
            objetoPersonagem.idade = 32;
            objetoPersonagem.armadura = "Voadora";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "Joyce";
            objetoPersonagem2.idade = 18;
            objetoPersonagem2.armadura = "Flash";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem.nome} - {objetoPersonagem.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");




        }
    }
}
