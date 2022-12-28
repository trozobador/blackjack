using BlackJack.Interface;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BlackJack.Model
{
    public class Mao : iMao
    {
        public Dictionary<int, Carta>? Dealer { get; set; }
        public Dictionary<int, Carta>? DealerClosed { get; set; }
        public Dictionary<int, Carta>? Player { get; set; }
        public int TotalDealer { get; set; }
        public int TotalPlayer { get; set; }
        public bool dealeropen { get; set; }
    }
}
