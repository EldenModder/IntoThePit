using System.Numerics;
using Raylib_cs;

//Static using
using static Raylib_cs.Raylib;

namespace IntoThePit
{
    internal class Input
    {
        private Player player;
        private UI ui;
        private Utils utils;

        public Input(Player player, UI ui, Utils utils)
        {
            this.player = player;
            this.ui = ui;
            this.utils = utils;
        }

        public void Move()
        {
            Vector2 position = ReadInput();
            player.Position += position;
            utils.ClampPlayerPosition();
        }

        public Vector2 ReadInput()
        {
            if (IsKeyPressed(KeyboardKey.Up)) return new Vector2(0, -10);
            else if (IsKeyPressed(KeyboardKey.Down)) return new Vector2(0, 10);
            else if (IsKeyPressed(KeyboardKey.Left)) return new Vector2(-10, 0);
            else if (IsKeyPressed(KeyboardKey.Right)) return new Vector2(10, 0);
            else return Vector2.Zero;
        }
    }
}
