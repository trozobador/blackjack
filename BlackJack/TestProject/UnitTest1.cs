using BlackJack.Controllers;
using BlackJack.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace TestProject
{
    public class UnitTest1
    {
        private readonly RodadaController _controller;
        private readonly MemoryCache _memoryCache;

        public UnitTest1()
        {
            MemoryCacheOptions cacheOptions = new MemoryCacheOptions();
            cacheOptions.ExpirationScanFrequency = TimeSpan.FromSeconds(2);
            _memoryCache = new MemoryCache(cacheOptions);
            _controller = new RodadaController(_memoryCache);
        }

        [Fact]
        
        public void TesteIniciar()
        {

            var actionResult = _controller.Iniciar();
            Assert.IsAssignableFrom<iMao>(((ObjectResult)actionResult).Value);
        }

        [Fact]
        public void TestePlayer()
        {

            var actionResult = _controller.PlayerPlay();
            Assert.IsAssignableFrom<iMao>(((ObjectResult)actionResult).Value);
        }
        [Fact]
        public void TesteDealer()
        {

            var actionResult = _controller.DealerPlay();
            Assert.IsAssignableFrom<iMao>(((ObjectResult)actionResult).Value);
        }
    }
}