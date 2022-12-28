namespace BlackJack.Service
{
    public static class sort
    {
        public static int proximacarta(int[] usadas)
        {
            return selecionarcarta(usadas);
        }

        private static int selecionarcarta(int[] usadas)
        {
            var carta = randomize();
            if (usadas.Where(x => x == carta).ToList().Count == 0)
            {
                return carta;
            }
            else
                return selecionarcarta(usadas);
        }

        private static int randomize()
        {

            Random rnd = new Random();
            return rnd.Next(1, 53);

        }
    }
}
