using BlackJack.Interface;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BlackJack.Model
{
    public class Baralho : iBaralho
    {
        private Dictionary<int, Carta> cartaList;

        public Baralho()
        {
            cartaList = new Dictionary<int, Carta>
            {
                { 1, new Carta { Naipe = "Copas", Nome = "As", valor = 1 } },
                { 2, new Carta { Naipe = "Copas", Nome = "2", valor = 2 } },
                { 3, new Carta { Naipe = "Copas", Nome = "3", valor = 3 } },
                { 4, new Carta { Naipe = "Copas", Nome = "4", valor = 4 } },
                { 5, new Carta { Naipe = "Copas", Nome = "5", valor = 5 } },
                { 6, new Carta { Naipe = "Copas", Nome = "6", valor = 6 } },
                { 7, new Carta { Naipe = "Copas", Nome = "7", valor = 7 } },
                { 8, new Carta { Naipe = "Copas", Nome = "8", valor = 8 } },
                { 9, new Carta { Naipe = "Copas", Nome = "9", valor = 9 } },
                { 10, new Carta { Naipe = "Copas", Nome = "10", valor = 10 } },
                { 11, new Carta { Naipe = "Copas", Nome = "K", valor = 10 } },
                { 12, new Carta { Naipe = "Copas", Nome = "Q", valor = 10 } },
                { 13, new Carta { Naipe = "Copas", Nome = "J", valor = 10 } },
                { 14, new Carta { Naipe = "Paus", Nome = "As", valor = 1 } },
                { 15, new Carta { Naipe = "Paus", Nome = "2", valor = 2 } },
                { 16, new Carta { Naipe = "Paus", Nome = "3", valor = 3 } },
                { 17, new Carta { Naipe = "Paus", Nome = "4", valor = 4 } },
                { 18, new Carta { Naipe = "Paus", Nome = "5", valor = 5 } },
                { 19, new Carta { Naipe = "Paus", Nome = "6", valor = 6 } },
                { 20, new Carta { Naipe = "Paus", Nome = "7", valor = 7 } },
                { 21, new Carta { Naipe = "Paus", Nome = "8", valor = 8 } },
                { 22, new Carta { Naipe = "Paus", Nome = "9", valor = 9 } },
                { 23, new Carta { Naipe = "Paus", Nome = "10", valor = 10 } },
                { 24, new Carta { Naipe = "Paus", Nome = "K", valor = 10 } },
                { 25, new Carta { Naipe = "Paus", Nome = "Q", valor = 10 } },
                { 26, new Carta { Naipe = "Paus", Nome = "J", valor = 10 } },
                { 27, new Carta { Naipe = "Espadas", Nome = "As", valor = 1 } },
                { 28, new Carta { Naipe = "Espadas", Nome = "2", valor = 2 } },
                { 29, new Carta { Naipe = "Espadas", Nome = "3", valor = 3 } },
                { 30, new Carta { Naipe = "Espadas", Nome = "4", valor = 4 } },
                { 31, new Carta { Naipe = "Espadas", Nome = "5", valor = 5 } },
                { 32, new Carta { Naipe = "Espadas", Nome = "6", valor = 6 } },
                { 33, new Carta { Naipe = "Espadas", Nome = "7", valor = 7 } },
                { 34, new Carta { Naipe = "Espadas", Nome = "8", valor = 8 } },
                { 35, new Carta { Naipe = "Espadas", Nome = "9", valor = 9 } },
                { 36, new Carta { Naipe = "Espadas", Nome = "10", valor = 10 } },
                { 37, new Carta { Naipe = "Espadas", Nome = "K", valor = 10 } },
                { 38, new Carta { Naipe = "Espadas", Nome = "Q", valor = 10 } },
                { 39, new Carta { Naipe = "Espadas", Nome = "J", valor = 10 } },
                { 40, new Carta { Naipe = "Ouro", Nome = "As", valor = 1 } },
                { 41, new Carta { Naipe = "Ouro", Nome = "2", valor = 2 } },
                { 42, new Carta { Naipe = "Ouro", Nome = "3", valor = 3 } },
                { 43, new Carta { Naipe = "Ouro", Nome = "4", valor = 4 } },
                { 44, new Carta { Naipe = "Ouro", Nome = "5", valor = 5 } },
                { 45, new Carta { Naipe = "Ouro", Nome = "6", valor = 6 } },
                { 46, new Carta { Naipe = "Ouro", Nome = "7", valor = 7 } },
                { 47, new Carta { Naipe = "Ouro", Nome = "8", valor = 8 } },
                { 48, new Carta { Naipe = "Ouro", Nome = "9", valor = 9 } },
                { 49, new Carta { Naipe = "Ouro", Nome = "10", valor = 10 } },
                { 50, new Carta { Naipe = "Ouro", Nome = "K", valor = 10 } },
                { 51, new Carta { Naipe = "Ouro", Nome = "Q", valor = 10 } },
                { 52, new Carta { Naipe = "Ouro", Nome = "J", valor = 10 } }
            };
        }
        public Dictionary<int, Carta> cartas => cartaList;
    }
}
