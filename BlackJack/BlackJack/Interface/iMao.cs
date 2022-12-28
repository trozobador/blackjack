using BlackJack.Model;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BlackJack.Interface
{
    public interface iMao
    {
        Dictionary<int, Carta>? Dealer { get; set; }
        Dictionary<int, Carta>? DealerClosed { get; set; }

        Dictionary<int, Carta>? Player { get; set; }
        int TotalDealer { get; set; }
        int TotalPlayer { get; set; }
        bool dealeropen { get; set; }   
    }
}
