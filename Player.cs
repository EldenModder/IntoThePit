using System.Numerics;

namespace IntoThePit
{
    internal class Player
    {
        private Game game;
        public Player(Game game) => this.game = game;

        public string Glyph = "P";
        public Vector2 Position;
        public Vector2 Size = new(10, 16);
    }
}
