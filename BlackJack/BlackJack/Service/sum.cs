using BlackJack.Interface;
using BlackJack.Model;

namespace BlackJack.Service
{
    public static class sum
    {
        public static iMao Somarmaos(iMao mao)
        {
            iMao result = mao;
            result.TotalPlayer = 0;
            result.TotalDealer = 0;


            foreach (var carta in mao.Player.Values)
            {
                result.TotalPlayer += carta.valor;
            }

            foreach (var carta in mao.Dealer.Values)
            {
                result.TotalDealer += carta.valor;
            }

            if (mao.Dealer.FirstOrDefault().Value.valor == 10 || mao.Dealer.FirstOrDefault().Value.valor == 1|| mao.Dealer.Count() > 1 || mao.dealeropen) 
            {
                foreach (var carta in mao.DealerClosed.Values)
                {
                    result.TotalDealer += carta.valor;
                }
            }

            return result;
        }


    }
}
