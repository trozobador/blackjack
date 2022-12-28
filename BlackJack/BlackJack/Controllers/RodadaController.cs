using BlackJack.Interface;
using BlackJack.Model;
using BlackJack.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BlackJack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RodadaController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        private readonly iBaralho _baralho;

        public RodadaController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _baralho = new Baralho();  
        }

        [HttpGet("iniciar")]
        public IActionResult Iniciar()
        {
            iMao mao = new Mao();
            int[] usadas = new int[52];

            mao.Dealer = new Dictionary<int, Carta>();
            mao.DealerClosed = new Dictionary<int, Carta>();
            mao.Player = new Dictionary<int, Carta>();

            int selecao = 0;
            Carta carta = new Carta();

            selecao = sort.proximacarta(usadas);
            usadas[1] = selecao;
            carta = _baralho.cartas[selecao];
            mao.Dealer.Add(selecao, carta);

            selecao = sort.proximacarta(usadas);
            usadas[2] = selecao;
            carta = _baralho.cartas[selecao];
            mao.DealerClosed.Add(selecao, carta);

            selecao = sort.proximacarta(usadas);
            usadas[3] = selecao;
            carta = _baralho.cartas[selecao];
            mao.Player.Add(selecao, carta);

            selecao = sort.proximacarta(usadas);
            usadas[4] = selecao;
            carta = _baralho.cartas[selecao];
            mao.Player.Add(selecao, carta);

            _memoryCache.Set("rodada", mao);
            _memoryCache.Set("usadas", usadas);
            _memoryCache.Set("totalcartas", 4);

            if(mao.Dealer.FirstOrDefault().Value.valor != 10 && mao.Dealer.FirstOrDefault().Value.valor != 1)
            mao.DealerClosed = new Dictionary<int, Carta>();

            return Ok(sum.Somarmaos(mao));  
        }

        [HttpGet("playerplay")]
        public IActionResult PlayerPlay()
        {
            Mao mao = null;
            int[] usadas;
            int totalcartas;


            _memoryCache.TryGetValue("rodada", out mao);
            _memoryCache.TryGetValue("usadas", out usadas);
            _memoryCache.TryGetValue("totalcartas", out totalcartas);

            int selecao = 0;
            Carta carta = new Carta();
            totalcartas++;

            selecao = sort.proximacarta(usadas);
            usadas[totalcartas] = selecao;
            carta = _baralho.cartas[selecao];
            mao.Player.Add(selecao, carta);

            _memoryCache.Set("rodada", mao);
            _memoryCache.Set("usadas", usadas);
            _memoryCache.Set("totalcartas", totalcartas);

            if (mao.Dealer.FirstOrDefault().Value.valor != 10 && mao.Dealer.FirstOrDefault().Value.valor != 1 && !mao.dealeropen)
                mao.DealerClosed = new Dictionary<int, Carta>();

            return Ok(sum.Somarmaos(mao));

        }

        [HttpGet("dealerplay")]
        public IActionResult DealerPlay()
        {
            Mao mao = null;
            int[] usadas;
            int totalcartas;


            _memoryCache.TryGetValue("rodada", out mao);
            _memoryCache.TryGetValue("usadas", out usadas);
            _memoryCache.TryGetValue("totalcartas", out totalcartas);

            if (mao.dealeropen)
            {
                int selecao = 0;
                Carta carta = new Carta();
                totalcartas++;

                selecao = sort.proximacarta(usadas);
                usadas[totalcartas] = selecao;
                carta = _baralho.cartas[selecao];
                mao.Player.Add(selecao, carta);
            }

            mao.dealeropen = true;
            _memoryCache.Set("rodada", mao);
            _memoryCache.Set("usadas", usadas);
            _memoryCache.Set("totalcartas", totalcartas);

            return Ok(sum.Somarmaos(mao));

        }
    }
}
