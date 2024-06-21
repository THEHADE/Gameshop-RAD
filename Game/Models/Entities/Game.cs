namespace GameShop.Models.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Cover { get; set; }

    }
}
