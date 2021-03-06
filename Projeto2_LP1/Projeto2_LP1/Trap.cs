﻿namespace Projeto2_LP1
{
    /// <summary>
    /// Esta classe herda da interface IGameObject. É composta por três 
    /// propriedades, um constructor e um método override ToString();. 
    /// </summary>
    class Trap : IGameObject
    {
        /// <summary>
        /// Nestas quatro propriedades auto-implementadas, é nos permitido indicar
        /// e obter o nome, o símbolo da armadilha e o  dano causado ao jogador
        /// caso, este acione a armadilha. A ultima propriedade, Explored
        /// permite-nos revelar a vizinhaça do jogador á medida que ele 
        /// explora o mapa.
        /// /// </summary>
        public string Name { get; set; }
        public string Symbol { get; set; }
        public float Damage { get; set; }
        public bool Explored { get; set; }
        public bool FallenInto { get; set; }

        /// <summary>
        /// O Constructor Trap indica o nome da armadilha, o símbolo que foi 
        /// dado através da codificação UTF-8 e a quantidade de dano que o 
        /// jogador poderá perder quando se deparar com ela. Indica ainda
        /// através de um booleano se o Tile aonde se encontra aparece explorado 
        /// revelando-se assim ao jogador.
        /// </summary>
        /// <param name="name">O nome dado a armadilha na altura da criação da 
        /// mesma no nosso código</param>
        /// <param name="damage">Dano que o jogador irá receber caso "se encontre"
        /// com uma armadilha</param>
        public Trap(string name, int damage)
        {
            Name = name;
            Symbol = "\u25B2 ";
            Damage = damage;
            Explored = false;
            FallenInto = false;
        }

        /// <summary>
        /// Através do override é possivel modificar o método ToString para 
        /// devolver o símbolo escolhido para a grid de visualização.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
